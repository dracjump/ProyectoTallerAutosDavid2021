namespace ProyectoTallerAutos.Windows.Clientes.FormAE
{
    partial class FrmLocalidadesAE
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLocalidad = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProvincias = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAgregarProvincia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Localidad :";
            // 
            // txbLocalidad
            // 
            // 
            // 
            // 
            this.txbLocalidad.CustomButton.Image = null;
            this.txbLocalidad.CustomButton.Location = new System.Drawing.Point(378, 1);
            this.txbLocalidad.CustomButton.Name = "";
            this.txbLocalidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbLocalidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbLocalidad.CustomButton.TabIndex = 1;
            this.txbLocalidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbLocalidad.CustomButton.UseSelectable = true;
            this.txbLocalidad.CustomButton.Visible = false;
            this.txbLocalidad.Lines = new string[0];
            this.txbLocalidad.Location = new System.Drawing.Point(119, 88);
            this.txbLocalidad.MaxLength = 100;
            this.txbLocalidad.Name = "txbLocalidad";
            this.txbLocalidad.PasswordChar = '\0';
            this.txbLocalidad.PromptText = "Ingrese una Localidad";
            this.txbLocalidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbLocalidad.SelectedText = "";
            this.txbLocalidad.SelectionLength = 0;
            this.txbLocalidad.SelectionStart = 0;
            this.txbLocalidad.ShortcutsEnabled = true;
            this.txbLocalidad.Size = new System.Drawing.Size(400, 23);
            this.txbLocalidad.TabIndex = 0;
            this.txbLocalidad.UseSelectable = true;
            this.txbLocalidad.WaterMark = "Ingrese una Localidad";
            this.txbLocalidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbLocalidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.cancel_50px;
            this.btnCancelar.Location = new System.Drawing.Point(384, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 56);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.ok_50px;
            this.btnOk.Location = new System.Drawing.Point(42, 238);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(135, 56);
            this.btnOk.TabIndex = 2;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Provincia :";
            // 
            // cbxProvincias
            // 
            this.cbxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvincias.FormattingEnabled = true;
            this.cbxProvincias.Location = new System.Drawing.Point(119, 140);
            this.cbxProvincias.Name = "cbxProvincias";
            this.cbxProvincias.Size = new System.Drawing.Size(325, 24);
            this.cbxProvincias.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAgregarProvincia
            // 
            this.btnAgregarProvincia.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.plus_25px;
            this.btnAgregarProvincia.Location = new System.Drawing.Point(464, 132);
            this.btnAgregarProvincia.Name = "btnAgregarProvincia";
            this.btnAgregarProvincia.Size = new System.Drawing.Size(55, 38);
            this.btnAgregarProvincia.TabIndex = 6;
            this.btnAgregarProvincia.UseVisualStyleBackColor = false;
            this.btnAgregarProvincia.Click += new System.EventHandler(this.btnAgregarProvincia_Click);
            // 
            // FrmLocalidadesAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 337);
            this.Controls.Add(this.btnAgregarProvincia);
            this.Controls.Add(this.cbxProvincias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbLocalidad);
            this.Controls.Add(this.label1);
            this.Name = "FrmLocalidadesAE";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Nueva Localidad";
            this.Load += new System.EventHandler(this.FrmLocalidadesAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txbLocalidad;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProvincias;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAgregarProvincia;
    }
}