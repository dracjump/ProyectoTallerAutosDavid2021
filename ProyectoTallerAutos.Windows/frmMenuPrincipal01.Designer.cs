namespace ProyectoTallerAutos.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeViehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeAutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEstados = new System.Windows.Forms.Button();
            this.btnFichaAutos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(25, 75);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(950, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.fichaDeAutosToolStripMenuItem,
            this.estadosToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.tiposDeViehiculosToolStripMenuItem});
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.modelosToolStripMenuItem.Text = "Modelos";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // tiposDeViehiculosToolStripMenuItem
            // 
            this.tiposDeViehiculosToolStripMenuItem.Name = "tiposDeViehiculosToolStripMenuItem";
            this.tiposDeViehiculosToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.tiposDeViehiculosToolStripMenuItem.Text = "Tipos De Viehiculos";
            this.tiposDeViehiculosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeViehiculosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadesToolStripMenuItem,
            this.provinciasToolStripMenuItem,
            this.tiposDeDocumentosToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // provinciasToolStripMenuItem
            // 
            this.provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            this.provinciasToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.provinciasToolStripMenuItem.Text = "Provincias";
            this.provinciasToolStripMenuItem.Click += new System.EventHandler(this.provinciasToolStripMenuItem_Click);
            // 
            // tiposDeDocumentosToolStripMenuItem
            // 
            this.tiposDeDocumentosToolStripMenuItem.Name = "tiposDeDocumentosToolStripMenuItem";
            this.tiposDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.tiposDeDocumentosToolStripMenuItem.Text = "Tipos de documentos";
            this.tiposDeDocumentosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDocumentosToolStripMenuItem_Click);
            // 
            // fichaDeAutosToolStripMenuItem
            // 
            this.fichaDeAutosToolStripMenuItem.Name = "fichaDeAutosToolStripMenuItem";
            this.fichaDeAutosToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.fichaDeAutosToolStripMenuItem.Text = "Ficha de Autos";
            this.fichaDeAutosToolStripMenuItem.Click += new System.EventHandler(this.fichaDeAutosToolStripMenuItem_Click);
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            this.estadosToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.estadosToolStripMenuItem.Text = "Estados";
            this.estadosToolStripMenuItem.Click += new System.EventHandler(this.estadosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Starcraft", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(856, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "By DRAC V1.3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Radio Stars", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.Exit;
            this.btnSalir.Location = new System.Drawing.Point(816, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 76);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEstados
            // 
            this.btnEstados.Font = new System.Drawing.Font("Radio Stars", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstados.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.Estados;
            this.btnEstados.Location = new System.Drawing.Point(25, 450);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(159, 76);
            this.btnEstados.TabIndex = 3;
            this.btnEstados.Text = "Estados";
            this.btnEstados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstados.UseVisualStyleBackColor = false;
            this.btnEstados.Click += new System.EventHandler(this.btnEstados_Click);
            // 
            // btnFichaAutos
            // 
            this.btnFichaAutos.Font = new System.Drawing.Font("Radio Stars", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichaAutos.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.save_archive_36px;
            this.btnFichaAutos.Location = new System.Drawing.Point(25, 341);
            this.btnFichaAutos.Name = "btnFichaAutos";
            this.btnFichaAutos.Size = new System.Drawing.Size(159, 76);
            this.btnFichaAutos.TabIndex = 3;
            this.btnFichaAutos.Text = "Ficha de Autos";
            this.btnFichaAutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFichaAutos.UseVisualStyleBackColor = false;
            this.btnFichaAutos.Click += new System.EventHandler(this.btnFichaAutos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Radio Stars", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.search_client_36px;
            this.btnClientes.Location = new System.Drawing.Point(25, 237);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(159, 76);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.Font = new System.Drawing.Font("Radio Stars", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelos.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.tesla_model_x_36px;
            this.btnModelos.Location = new System.Drawing.Point(25, 128);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(159, 76);
            this.btnModelos.TabIndex = 3;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModelos.UseVisualStyleBackColor = false;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEstados);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnFichaAutos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnModelos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(25, 75, 25, 25);
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Menú Principal";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeAutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFichaAutos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeViehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentosToolStripMenuItem;
    }
}

