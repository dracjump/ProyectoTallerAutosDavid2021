namespace ProyectoTallerAutos.Windows.Modelos.FormAE
{
    partial class FrmModelosAE
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbModelo = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAgregarTipo = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lvlTipoVehiculoModelo = new System.Windows.Forms.Label();
            this.lvlMarcaModelo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Modelo :";
            // 
            // txbModelo
            // 
            // 
            // 
            // 
            this.txbModelo.CustomButton.Image = null;
            this.txbModelo.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txbModelo.CustomButton.Name = "";
            this.txbModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbModelo.CustomButton.TabIndex = 1;
            this.txbModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbModelo.CustomButton.UseSelectable = true;
            this.txbModelo.CustomButton.Visible = false;
            this.txbModelo.Lines = new string[0];
            this.txbModelo.Location = new System.Drawing.Point(135, 191);
            this.txbModelo.MaxLength = 32767;
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.PasswordChar = '\0';
            this.txbModelo.PromptText = "Ingrese un Modelo";
            this.txbModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbModelo.SelectedText = "";
            this.txbModelo.SelectionLength = 0;
            this.txbModelo.SelectionStart = 0;
            this.txbModelo.ShortcutsEnabled = true;
            this.txbModelo.Size = new System.Drawing.Size(324, 23);
            this.txbModelo.TabIndex = 0;
            this.txbModelo.UseSelectable = true;
            this.txbModelo.WaterMark = "Ingrese un Modelo";
            this.txbModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.cancel_50px;
            this.btnCancelar.Location = new System.Drawing.Point(392, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 56);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.ok_50px;
            this.btnOk.Location = new System.Drawing.Point(27, 264);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(135, 56);
            this.btnOk.TabIndex = 1;
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnAgregarTipo
            // 
            this.btnAgregarTipo.Location = new System.Drawing.Point(422, 137);
            this.btnAgregarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTipo.Name = "btnAgregarTipo";
            this.btnAgregarTipo.Size = new System.Drawing.Size(37, 34);
            this.btnAgregarTipo.TabIndex = 13;
            this.btnAgregarTipo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(422, 89);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(37, 34);
            this.btnAgregarMarca.TabIndex = 12;
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(135, 143);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(270, 24);
            this.cbxTipo.TabIndex = 10;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(135, 95);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(270, 24);
            this.cbxMarca.TabIndex = 11;
            // 
            // lvlTipoVehiculoModelo
            // 
            this.lvlTipoVehiculoModelo.AutoSize = true;
            this.lvlTipoVehiculoModelo.Location = new System.Drawing.Point(24, 137);
            this.lvlTipoVehiculoModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvlTipoVehiculoModelo.Name = "lvlTipoVehiculoModelo";
            this.lvlTipoVehiculoModelo.Size = new System.Drawing.Size(44, 17);
            this.lvlTipoVehiculoModelo.TabIndex = 8;
            this.lvlTipoVehiculoModelo.Text = "Tipo: ";
            // 
            // lvlMarcaModelo
            // 
            this.lvlMarcaModelo.AutoSize = true;
            this.lvlMarcaModelo.Location = new System.Drawing.Point(24, 95);
            this.lvlMarcaModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvlMarcaModelo.Name = "lvlMarcaModelo";
            this.lvlMarcaModelo.Size = new System.Drawing.Size(55, 17);
            this.lvlMarcaModelo.TabIndex = 9;
            this.lvlMarcaModelo.Text = "Marca: ";
            // 
            // FrmModelosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 343);
            this.Controls.Add(this.btnAgregarTipo);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lvlTipoVehiculoModelo);
            this.Controls.Add(this.lvlMarcaModelo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.label1);
            this.Name = "FrmModelosAE";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Nuevo Modelo";
            this.Load += new System.EventHandler(this.FrmMarcasAE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txbModelo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarTipo;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lvlTipoVehiculoModelo;
        private System.Windows.Forms.Label lvlMarcaModelo;
    }
}