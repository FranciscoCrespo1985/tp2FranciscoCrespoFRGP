namespace Views
{
    partial class FrmNuevoArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbImagen = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.lb_Precio = new System.Windows.Forms.Label();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.btnImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(396, 249);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(315, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(105, 189);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 2;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(105, 218);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(30, 93);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(42, 13);
            this.lbImagen.TabIndex = 4;
            this.lbImagen.Text = "Imagen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(30, 189);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "Marca";
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(30, 221);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(52, 13);
            this.Categoria.TabIndex = 7;
            this.Categoria.Text = "Categoria";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(30, 61);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 8;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(30, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 9;
            this.lbNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(105, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(105, 59);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 10;
            // 
            // tbImagen
            // 
            this.tbImagen.Enabled = false;
            this.tbImagen.Location = new System.Drawing.Point(105, 89);
            this.tbImagen.Name = "tbImagen";
            this.tbImagen.Size = new System.Drawing.Size(100, 20);
            this.tbImagen.TabIndex = 10;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(105, 119);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 10;
            // 
            // pbox
            // 
            this.pbox.Image = global::Views.Properties.Resources.placeholder;
            this.pbox.InitialImage = global::Views.Properties.Resources.placeholder;
            this.pbox.Location = new System.Drawing.Point(300, 29);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(171, 173);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 11;
            this.pbox.TabStop = false;
            // 
            // lb_Precio
            // 
            this.lb_Precio.AutoSize = true;
            this.lb_Precio.Location = new System.Drawing.Point(30, 156);
            this.lb_Precio.Name = "lb_Precio";
            this.lb_Precio.Size = new System.Drawing.Size(37, 13);
            this.lb_Precio.TabIndex = 5;
            this.lb_Precio.Text = "Precio";
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(105, 153);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(100, 20);
            this.tb_precio.TabIndex = 10;
            this.tb_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_precio_KeyPress);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(211, 89);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(60, 21);
            this.btnImagen.TabIndex = 12;
            this.btnImagen.Text = "Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // FrmNuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 299);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbImagen);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lb_Precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmNuevoArticulo";
            this.Text = "frmCargarArticulo";
            this.Load += new System.EventHandler(this.FrmNuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbImagen;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Label lb_Precio;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Button btnImagen;
    }
}