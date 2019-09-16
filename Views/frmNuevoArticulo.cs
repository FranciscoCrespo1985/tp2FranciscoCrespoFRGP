using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

using System.Text.RegularExpressions;

namespace Views
{
    public partial class FrmNuevoArticulo : Form
    {
        private frmPantallaPrincipal.UpdateDGV uDGV;
        private Articulo articulo = null;
        private string imagePath = null;
        public FrmNuevoArticulo() {

            InitializeComponent();
            this.BringToFront();
            tbCodigo.MaxLength = 50;
            tbNombre.MaxLength = 50;
            tbDescripcion.MaxLength = 150;
        }
        public FrmNuevoArticulo(Articulo articulo, frmPantallaPrincipal.UpdateDGV uDGV)
        {

            InitializeComponent();
            this.articulo = articulo;
            this.BringToFront();
            tbCodigo.MaxLength = 50;
            tbNombre.MaxLength = 50;
            tbDescripcion.MaxLength = 150;

            this.uDGV = uDGV;
        }

        public FrmNuevoArticulo(frmPantallaPrincipal.UpdateDGV uDGV)
        {
            InitializeComponent();
            this.BringToFront();
            tbCodigo.MaxLength = 50;
            tbNombre.MaxLength = 50;
            tbDescripcion.MaxLength = 150;

            this.uDGV = uDGV;
        }

        private void FrmNuevoArticulo_Load(object sender, EventArgs e)
        {

            
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            // CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {

                cboMarca.DataSource = marca.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "descripcion";
                cboMarca.SelectedIndex = -1;
                cboCategoria.DataSource = categoria.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "descripcion";
                cboCategoria.SelectedIndex = -1;

                if (articulo != null)
                {
                    
                    if (articulo.Imagen.Length==0 || articulo.Imagen.Contains("null"))
                        articulo.Imagen = System.IO.Path.GetFullPath(@"..\..\Images\placeholder.png");
                    Bitmap image = new Bitmap(articulo.Imagen);
                    Text = "Modificar";
                    tbNombre.Text = articulo.Nombre;
                    tbDescripcion.Text = articulo.Descripcion;
                    pbox.Image = image;
                    tbCodigo.Text = articulo.Codigo;
                    tb_precio.Text = string.Format("{0:N2}", articulo.Precio);
                    cboMarca.SelectedIndex = articulo.Marca.id-1;
                    cboCategoria.SelectedIndex = articulo.Categoria.id-1;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Tb_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Regex.IsMatch(tb_precio.Text, @"\.\d\d")&& e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            if(articulo == null)
                articulo = new Articulo();
            
            
            try
            {
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Codigo = tbCodigo.Text;
                articulo.Descripcion = tbDescripcion.Text;
                articulo.Imagen = tbImagen.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Precio = float.Parse(tb_precio.Text);

                if (articulo.Id != 0)
                    articuloNegocio.modificar(articulo);
                else
                    articuloNegocio.AgregarArticulo(articulo);
              
               
                Dispose();
                uDGV();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Elija una imagen";
            opf.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (opf.ShowDialog() == DialogResult.OK) {
                Bitmap image = new Bitmap(opf.FileName);
                pbox.Image = image;
                tbImagen.Text = opf.FileName;
                
            }
            
            //Image imagen = Image.FromFile(@"~Views\images\placeholder.png");
           
        }
    }
}

