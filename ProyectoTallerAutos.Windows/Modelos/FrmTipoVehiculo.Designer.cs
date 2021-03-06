namespace ProyectoTallerAutos.Windows.Modelos
{
    partial class frmTipoVehiculo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.cmnTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTipoVehiculo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 647);
            this.panel1.TabIndex = 0;
            // 
            // dgvTipoVehiculo
            // 
            this.dgvTipoVehiculo.AllowUserToAddRows = false;
            this.dgvTipoVehiculo.AllowUserToDeleteRows = false;
            this.dgvTipoVehiculo.AllowUserToResizeColumns = false;
            this.dgvTipoVehiculo.AllowUserToResizeRows = false;
            this.dgvTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTipoVehiculo});
            this.dgvTipoVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoVehiculo.Location = new System.Drawing.Point(0, 0);
            this.dgvTipoVehiculo.Name = "dgvTipoVehiculo";
            this.dgvTipoVehiculo.ReadOnly = true;
            this.dgvTipoVehiculo.RowHeadersVisible = false;
            this.dgvTipoVehiculo.RowHeadersWidth = 51;
            this.dgvTipoVehiculo.RowTemplate.Height = 24;
            this.dgvTipoVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoVehiculo.Size = new System.Drawing.Size(617, 647);
            this.dgvTipoVehiculo.TabIndex = 0;
            // 
            // cmnTipoVehiculo
            // 
            this.cmnTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoVehiculo.HeaderText = "Tipo de Vehiculo";
            this.cmnTipoVehiculo.MinimumWidth = 6;
            this.cmnTipoVehiculo.Name = "cmnTipoVehiculo";
            this.cmnTipoVehiculo.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.delete_bin_18px;
            this.btnEliminar.Location = new System.Drawing.Point(324, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(47, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.edit_18px;
            this.btnEditar.Location = new System.Drawing.Point(377, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 37);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.search_18px;
            this.btnBuscar.Location = new System.Drawing.Point(430, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.update_left_rotation_18px;
            this.btnActualizar.Location = new System.Drawing.Point(483, 20);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(47, 37);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.print_18px;
            this.btnImprimir.Location = new System.Drawing.Point(536, 20);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(47, 37);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.delete_20px;
            this.btnSalir.Location = new System.Drawing.Point(589, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.plus_25px;
            this.btnNuevo.Location = new System.Drawing.Point(271, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(47, 37);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 727);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Name = "frmTipoVehiculo";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Tipo de Vehiculo";
            this.Load += new System.EventHandler(this.FrmModelos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTipoVehiculo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoVehiculo;
    }
}