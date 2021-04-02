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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modelo :";
            // 
            // txbModelo
            // 
            // 
            // 
            // 
            this.txbModelo.CustomButton.Image = null;
            this.txbModelo.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txbModelo.CustomButton.Name = "";
            this.txbModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbModelo.CustomButton.TabIndex = 1;
            this.txbModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbModelo.CustomButton.UseSelectable = true;
            this.txbModelo.CustomButton.Visible = false;
            this.txbModelo.Lines = new string[0];
            this.txbModelo.Location = new System.Drawing.Point(86, 88);
            this.txbModelo.MaxLength = 32767;
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.PasswordChar = '\0';
            this.txbModelo.PromptText = "Ingrese un Modelo";
            this.txbModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbModelo.SelectedText = "";
            this.txbModelo.SelectionLength = 0;
            this.txbModelo.SelectionStart = 0;
            this.txbModelo.ShortcutsEnabled = true;
            this.txbModelo.Size = new System.Drawing.Size(446, 23);
            this.txbModelo.TabIndex = 0;
            this.txbModelo.UseSelectable = true;
            this.txbModelo.WaterMark = "Ingrese un Modelo";
            this.txbModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.cancel_50px;
            this.btnCancelar.Location = new System.Drawing.Point(397, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 56);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.Image = global::ProyectoTallerAutos.Windows.Properties.Resources.ok_50px;
            this.btnOk.Location = new System.Drawing.Point(86, 175);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(135, 56);
            this.btnOk.TabIndex = 1;
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // FrmModelosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 254);
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
    }
}