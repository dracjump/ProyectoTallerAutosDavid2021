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

namespace ProyectoTallerAutos.Windows
{
    public partial class FrmEstadosAE : MetroFramework.Forms.MetroForm
    {
        public FrmEstadosAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (estado != null)
            {
                txbEstado.Text = estado.Descripcion;
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Estado estado;
        internal void SetEstado(Estado estado)
        {
            this.estado =  estado;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (estado == null)
                {
                    estado = new Estado();
                }
                estado.Descripcion = txbEstado.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txbEstado.Text.Trim()) &&
                string.IsNullOrWhiteSpace(txbEstado.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txbEstado, "Debe ingresar un Estado");
            }
            return valido;
        }

        internal Estado GetEstado()
        {
            return estado;
        }
    }
}
