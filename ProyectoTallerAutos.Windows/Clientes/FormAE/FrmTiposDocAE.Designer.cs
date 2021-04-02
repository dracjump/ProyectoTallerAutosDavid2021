namespace ProyectoTallerAutos.Windows.Clientes.FormAE
{
    partial class FrmTiposDocAE
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
            this.txbTipoDoc = new MetroFramework.Controls.MetroTextBox();
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
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo Doc :";
            // 
            // txbTipoDoc
            // 
            // 
            // 
            // 
            this.txbTipoDoc.CustomButton.Image = null;
            this.txbTipoDoc.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txbTipoDoc.CustomButton.Name = "";
            this.txbTipoDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbTipoDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbTipoDoc.CustomButton.TabIndex = 1;
            this.txbTipoDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTipoDoc.CustomButton.UseSelectable = true;
            this.txbTipoDoc.CustomButton.Visible = false;
            this.txbTipoDoc.Lines = new string[0];
            this.txbTipoDoc.Location = new System.Drawing.Point(86, 88);
            this.txbTipoDoc.MaxLength = 30;
            this.txbTipoDoc.Name = "txbTipoDoc";
            this.txbTipoDoc.PasswordChar = '\0';
            this.txbTipoDoc.PromptText = "Ingrese un Tipo documento";
            this.txbTipoDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTipoDoc.SelectedText = "";
            this.txbTipoDoc.SelectionLength = 0;
            this.txbTipoDoc.SelectionStart = 0;
            this.txbTipoDoc.ShortcutsEnabled = true;
            this.txbTipoDoc.Size = new System.Drawing.Size(446, 23);
            this.txbTipoDoc.TabIndex = 0;
            this.txbTipoDoc.UseSelectable = true;
            this.txbTipoDoc.WaterMark = "Ingrese un Tipo documento";
            this.txbTipoDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbTipoDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // FrmTiposDocAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 254);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbTipoDoc);
            this.Controls.Add(this.label1);
            this.Name = "FrmTiposDocAE";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Nuevo Tipo Documento";
            this.Load += new System.EventHandler(this.FrmMarcasAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txbTipoDoc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}