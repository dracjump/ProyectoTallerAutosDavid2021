using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerAutos.Windows.Modelos
{
    public partial class frmModelos : MetroFramework.Forms.MetroForm
    {
        public frmModelos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmModelos_Load(object sender, EventArgs e)
        {

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas frm = new frmMarcas();
            frm.ShowDialog(this);
        }

        private void tipoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoVehiculo frm = new frmTipoVehiculo();
            frm.ShowDialog(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
