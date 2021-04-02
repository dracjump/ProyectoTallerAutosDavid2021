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
    public partial class frmMarcasAE : MetroFramework.Forms.MetroForm
    {
        public frmMarcasAE()
        {
            InitializeComponent();
        }

        private void FrmMarcasAE_Load(object sender, EventArgs e)
        {

        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (marca != null)
            {
                txbMarca.Text = marca.NomMarca;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private MarcaAuto marca;
        internal void SetMarca(MarcaAuto marca)
        {
            this.marca = marca;
        }

        internal MarcaAuto GetMarca()
        {
            return marca;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (marca == null)
                {
                    marca = new MarcaAuto();
                }
                marca.NomMarca = txbMarca.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txbMarca.Text.Trim()) &&
                string.IsNullOrWhiteSpace(txbMarca.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txbMarca, "Debe ingresar una marca");
            }
            return valido;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
