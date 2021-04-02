namespace ProyectoTallerAutos.Windows.Modelos.FormAE
{
    partial class frmMarcasAE
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
            this.txbMarca = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca :";
            // 
            // txbMarca
            // 
            // 
            // 
            // 
            this.txbMarca.CustomButton.Image = null;
            this.txbMarca.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txbMarca.CustomButton.Name = "";
            this.txbMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbMarca.CustomButton.TabIndex = 1;
            this.txbMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbMarca.CustomButton.UseSelectable = true;
            this.txbMarca.CustomButton.Visible = false;
            this.txbMarca.Lines = new string[0];
            this.txbMarca.Location = new System.Drawing.Point(86, 88);
            this.txbMarca.MaxLength = 30;
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.PasswordChar = '\0';
            this.txbMarca.PromptText = "Ingrese una Marca";
            this.txbMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMarca.SelectedText = "";
            this.txbMarca.SelectionLength = 0;
            this.txbMarca.SelectionStart = 0;
            this.txbMarca.ShortcutsEnabled = true;
            this.txbMarca.Size = new System.Drawing.Size(446, 23);
            this.txbMarca.TabIndex = 0;
            this.txbMarca.UseSelectable = true;
            this.txbMarca.WaterMark = "Ingrese una Marca";
            this.txbMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.cancel_50px;
            this.btnCancelar.Location = new System.Drawing.Point(397, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 56);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.ok_50px;
            this.btnGuardar.Location = new System.Drawing.Point(86, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 56);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMarcasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 254);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.label1);
            this.Name = "frmMarcasAE";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Nueva Marca";
            this.Load += new System.EventHandler(this.FrmMarcasAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txbMarca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}