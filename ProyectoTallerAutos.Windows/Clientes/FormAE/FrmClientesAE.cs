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
    public partial class FrmClientesAE : MetroFramework.Forms.MetroForm
    {
        public FrmClientesAE()
        {
            InitializeComponent();
        }

        private void FrmMarcasAE_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
