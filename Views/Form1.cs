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

namespace Views
{
   
    public partial class frmPantallaPrincipal : Form
    {
        public delegate void UpdateDGV();
        public ArticuloNegocio articuloNegocio { get; set; }
        public List<Articulo> lista { get; set; }

        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            
            FrmNuevoArticulo ventana = new FrmNuevoArticulo(new UpdateDGV(updateDGV));
           
            ventana.Show();
        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            articuloNegocio = new ArticuloNegocio();
            try
            {
                updateDGV();
                //dgvListadoArticulo.DataSource = articuloNegocio.listar();
                //dgvListadoArticulo.Columns[0].Visible = false;
                //dgvListadoArticulo.Columns[3].Visible = false;
                //dgvListadoArticulo.Columns[6].Visible = false;
                //dgvListadoArticulo.Columns[8].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void updateDGV()
        {
            dgvListadoArticulo.DataSource = null;
            dgvListadoArticulo.Update();
            dgvListadoArticulo.Refresh();
            lista = articuloNegocio.listar();
            dgvListadoArticulo.DataSource = lista;
            dgvListadoArticulo.Columns[0].Visible = false;
            dgvListadoArticulo.Columns[3].Visible = false;
            dgvListadoArticulo.Columns[6].Visible = false;
            dgvListadoArticulo.Columns[8].Visible = false;
        }

        private void DgvListadoArticulo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modificar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void modificar()
        {
            Articulo modificar = (Articulo)dgvListadoArticulo.CurrentRow.DataBoundItem;

            FrmNuevoArticulo frmModificar = new FrmNuevoArticulo(modificar, updateDGV);
           
            
            // frmModificar.Text = "Modificar";
            frmModificar.ShowDialog();
            //updateDGV();

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoArticulo ventana = new FrmNuevoArticulo(new UpdateDGV(updateDGV));

            ventana.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                int id = ((Articulo)dgvListadoArticulo.CurrentRow.DataBoundItem).Id;
                negocio.eliminar(id);
                updateDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            try
            {
                if (tbBuscar.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(k => k.Marca.descripcion.ToLower().Contains(tbBuscar.Text.ToLower()) || k.Nombre.ToLower().Contains(tbBuscar.Text.ToLower()) || k.Categoria.descripcion.ToLower().Contains(tbBuscar.Text.ToLower()) );
                }
               dgvListadoArticulo.DataSource = listaFiltrada;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
