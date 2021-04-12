namespace ProyectoTallerAutos.Windows.FichasAutos
{
    partial class FrmFichasAutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFichasAutos = new System.Windows.Forms.DataGridView();
            this.cmnNombreCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnApellidoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichasAutos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFichasAutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 619);
            this.panel1.TabIndex = 0;
            // 
            // dgvFichasAutos
            // 
            this.dgvFichasAutos.AllowUserToAddRows = false;
            this.dgvFichasAutos.AllowUserToDeleteRows = false;
            this.dgvFichasAutos.AllowUserToResizeColumns = false;
            this.dgvFichasAutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFichasAutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFichasAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichasAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnNombreCli,
            this.cmnApellidoCli,
            this.cmnNumDoc,
            this.cmnMarca,
            this.cmnTipoVehiculo,
            this.cmnModelo,
            this.cmnPatente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFichasAutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFichasAutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFichasAutos.Location = new System.Drawing.Point(0, 0);
            this.dgvFichasAutos.Name = "dgvFichasAutos";
            this.dgvFichasAutos.ReadOnly = true;
            this.dgvFichasAutos.RowHeadersVisible = false;
            this.dgvFichasAutos.RowHeadersWidth = 51;
            this.dgvFichasAutos.RowTemplate.Height = 24;
            this.dgvFichasAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichasAutos.Size = new System.Drawing.Size(1443, 619);
            this.dgvFichasAutos.TabIndex = 0;
            // 
            // cmnNombreCli
            // 
            this.cmnNombreCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnNombreCli.HeaderText = "Nombre Cliente";
            this.cmnNombreCli.MinimumWidth = 6;
            this.cmnNombreCli.Name = "cmnNombreCli";
            this.cmnNombreCli.ReadOnly = true;
            // 
            // cmnApellidoCli
            // 
            this.cmnApellidoCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnApellidoCli.HeaderText = "Apellido";
            this.cmnApellidoCli.MinimumWidth = 6;
            this.cmnApellidoCli.Name = "cmnApellidoCli";
            this.cmnApellidoCli.ReadOnly = true;
            // 
            // cmnNumDoc
            // 
            this.cmnNumDoc.HeaderText = "Nº Doc";
            this.cmnNumDoc.MinimumWidth = 6;
            this.cmnNumDoc.Name = "cmnNumDoc";
            this.cmnNumDoc.ReadOnly = true;
            this.cmnNumDoc.Width = 125;
            // 
            // cmnMarca
            // 
            this.cmnMarca.HeaderText = "Marca";
            this.cmnMarca.MinimumWidth = 6;
            this.cmnMarca.Name = "cmnMarca";
            this.cmnMarca.ReadOnly = true;
            this.cmnMarca.Width = 125;
            // 
            // cmnTipoVehiculo
            // 
            this.cmnTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoVehiculo.HeaderText = "Tipo Vehiculo";
            this.cmnTipoVehiculo.MinimumWidth = 6;
            this.cmnTipoVehiculo.Name = "cmnTipoVehiculo";
            this.cmnTipoVehiculo.ReadOnly = true;
            // 
            // cmnModelo
            // 
            this.cmnModelo.HeaderText = "Modelo";
            this.cmnModelo.MinimumWidth = 6;
            this.cmnModelo.Name = "cmnModelo";
            this.cmnModelo.ReadOnly = true;
            this.cmnModelo.Width = 125;
            // 
            // cmnPatente
            // 
            this.cmnPatente.HeaderText = "Patente";
            this.cmnPatente.MinimumWidth = 6;
            this.cmnPatente.Name = "cmnPatente";
            this.cmnPatente.ReadOnly = true;
            this.cmnPatente.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadesToolStripMenuItem,
            this.provinciasToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadToolStripMenuItem,
            this.provinciaToolStripMenuItem,
            this.tipoDocumentoToolStripMenuItem});
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.localidadesToolStripMenuItem.Text = "Clientes";
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.localidadToolStripMenuItem.Text = "Localidad";
            // 
            // provinciaToolStripMenuItem
            // 
            this.provinciaToolStripMenuItem.Name = "provinciaToolStripMenuItem";
            this.provinciaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.provinciaToolStripMenuItem.Text = "Provincia";
            // 
            // tipoDocumentoToolStripMenuItem
            // 
            this.tipoDocumentoToolStripMenuItem.Name = "tipoDocumentoToolStripMenuItem";
            this.tipoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.tipoDocumentoToolStripMenuItem.Text = "Tipo documento";
            // 
            // provinciasToolStripMenuItem
            // 
            this.provinciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.tipoVehiculoToolStripMenuItem});
            this.provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            this.provinciasToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.provinciasToolStripMenuItem.Text = "Modelos";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // tipoVehiculoToolStripMenuItem
            // 
            this.tipoVehiculoToolStripMenuItem.Name = "tipoVehiculoToolStripMenuItem";
            this.tipoVehiculoToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.tipoVehiculoToolStripMenuItem.Text = "Tipo Vehiculo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.delete_bin_18px;
            this.btnEliminar.Location = new System.Drawing.Point(1147, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(47, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.edit_18px;
            this.btnEditar.Location = new System.Drawing.Point(1200, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 37);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.search_18px;
            this.btnBuscar.Location = new System.Drawing.Point(1253, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.update_left_rotation_18px;
            this.btnActualizar.Location = new System.Drawing.Point(1306, 20);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(47, 37);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.print_18px;
            this.btnImprimir.Location = new System.Drawing.Point(1359, 20);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(47, 37);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.delete_20px;
            this.btnSalir.Location = new System.Drawing.Point(1412, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.plus_25px;
            this.btnNuevo.Location = new System.Drawing.Point(1094, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(47, 37);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // FrmFichasAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 727);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1483, 727);
            this.MinimumSize = new System.Drawing.Size(1483, 727);
            this.Name = "FrmFichasAutos";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Fichas de Autos";
            this.Load += new System.EventHandler(this.FrmFichasAutos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichasAutos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvFichasAutos;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNombreCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnApellidoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPatente;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoVehiculoToolStripMenuItem;
    }
}