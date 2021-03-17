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
    public partial class frmTipoVehiculo : MetroFramework.Forms.MetroForm
    {
        public frmTipoVehiculo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmModelos_Load(object sender, EventArgs e)
        {

        }
    }
}
