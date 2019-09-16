namespace Views
{
    partial class frmPantallaPrincipal
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
            this.dgvListadoArticulo = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoArticulo
            // 
            this.dgvListadoArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulo.Location = new System.Drawing.Point(12, 50);
            this.dgvListadoArticulo.MultiSelect = false;
            this.dgvListadoArticulo.Name = "dgvListadoArticulo";
            this.dgvListadoArticulo.ReadOnly = true;
            this.dgvListadoArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoArticulo.Size = new System.Drawing.Size(752, 273);
            this.dgvListadoArticulo.TabIndex = 3;
            this.dgvListadoArticulo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListadoArticulo_CellMouseDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(691, 329);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(610, 329);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(529, 329);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(12, 12);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(558, 20);
            this.tbBuscar.TabIndex = 10;
            this.tbBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 358);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListadoArticulo);
            this.IsMdiContainer = true;
            this.Name = "frmPantallaPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListadoArticulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox tbBuscar;
    }
}

