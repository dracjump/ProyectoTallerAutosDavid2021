using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerAutos.Windows.Clientes.FormAE
{
    public partial class FrmTiposDocAE : MetroFramework.Forms.MetroForm
    {
        public FrmTiposDocAE()
        {
            InitializeComponent();
        }

        private void FrmMarcasAE_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLoad(levent);
            if (tipo != null)
            {
                txbTipoDoc.Text = tipo.Descripcion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private TipoDocumento tipo;
        internal void SetTipo(TipoDocumento tipo)
        {
            this.tipo = tipo;
        }

        internal TipoDocumento GetTipo()
        {
            return tipo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipo == null)
                {
                    tipo = new TipoDocumento();
                }
                tipo.Descripcion = txbTipoDoc.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txbTipoDoc.Text.Trim()) &&
                string.IsNullOrWhiteSpace(txbTipoDoc.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txbTipoDoc, "Debe ingresar un Tipo de documento");
            }
            return valido;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
