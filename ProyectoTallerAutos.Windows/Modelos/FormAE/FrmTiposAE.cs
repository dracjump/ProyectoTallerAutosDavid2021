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

namespace ProyectoTallerAutos.Windows.Modelos.FormAE
{
    public partial class FrmTiposAE : MetroFramework.Forms.MetroForm
    {
        public FrmTiposAE()
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
                txbTipo.Text = tipo.Descripcion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private TipoVehiculo tipo;
        internal void SetTipo(TipoVehiculo tipo)
        {
            this.tipo = tipo;
        }

        internal TipoVehiculo GetTipo()
        {
            return tipo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipo == null)
                {
                    tipo = new TipoVehiculo();
                }
                tipo.Descripcion = txbTipo.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txbTipo.Text.Trim()) &&
                string.IsNullOrWhiteSpace(txbTipo.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txbTipo, "Debe ingresar un Tipo");
            }
            return valido;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
