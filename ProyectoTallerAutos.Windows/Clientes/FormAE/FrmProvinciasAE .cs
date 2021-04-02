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
    public partial class FrmProvinciasAE : MetroFramework.Forms.MetroForm
    {
        public FrmProvinciasAE()
        {
            InitializeComponent();
        }

        private void FrmMarcasAE_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLoad(levent);
            if (provincia != null)
            {
                txbProvincia.Text = provincia.NombreProvincia;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Provincia provincia;
        internal void SetProvincia(Provincia provincia)
        {
            this.provincia = provincia;
        }

        internal Provincia GetProvincia()
        {
            return provincia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (provincia == null)
                {
                    provincia = new Provincia();
                }
                provincia.NombreProvincia = txbProvincia.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txbProvincia.Text.Trim()) &&
                string.IsNullOrWhiteSpace(txbProvincia.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txbProvincia, "Debe ingresar una provincia");
            }
            return valido;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
