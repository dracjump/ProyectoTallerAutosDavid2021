namespace ProyectoTallerAutos.Windows.Clientes
{
    partial class frmTipoDoc
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
            this.dgvTipoDoc = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmnTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTipoDoc);
            this.panel1.Location = new System.Drawing.Point(20, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 422);
            this.panel1.TabIndex = 0;
            // 
            // dgvTipoDoc
            // 
            this.dgvTipoDoc.AllowUserToAddRows = false;
            this.dgvTipoDoc.AllowUserToDeleteRows = false;
            this.dgvTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTipoDoc});
            this.dgvTipoDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoDoc.Location = new System.Drawing.Point(0, 0);
            this.dgvTipoDoc.Name = "dgvTipoDoc";
            this.dgvTipoDoc.ReadOnly = true;
            this.dgvTipoDoc.RowHeadersVisible = false;
            this.dgvTipoDoc.RowHeadersWidth = 51;
            this.dgvTipoDoc.RowTemplate.Height = 24;
            this.dgvTipoDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoDoc.Size = new System.Drawing.Size(366, 422);
            this.dgvTipoDoc.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.delete_20px;
            this.btnSalir.Location = new System.Drawing.Point(339, 63);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.print_18px;
            this.btnImprimir.Location = new System.Drawing.Point(286, 63);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(47, 37);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.update_left_rotation_18px;
            this.btnActualizar.Location = new System.Drawing.Point(233, 63);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(47, 37);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.search_18px;
            this.btnBuscar.Location = new System.Drawing.Point(180, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.edit_18px;
            this.btnEditar.Location = new System.Drawing.Point(127, 63);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 37);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.delete_bin_18px;
            this.btnEliminar.Location = new System.Drawing.Point(74, 63);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(47, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.plus_25px;
            this.btnNuevo.Location = new System.Drawing.Point(21, 63);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(47, 37);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // cmnTipoDoc
            // 
            this.cmnTipoDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoDoc.HeaderText = "Tipo de Documento";
            this.cmnTipoDoc.MinimumWidth = 6;
            this.cmnTipoDoc.Name = "cmnTipoDoc";
            this.cmnTipoDoc.ReadOnly = true;
            // 
            // frmTipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 567);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Name = "frmTipoDoc";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Tipo de Documento";
            this.Load += new System.EventHandler(this.FrmTipoDoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTipoDoc;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoDoc;
    }
}