using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerAutos.Windows.Clientes
{
    public partial class FrmFichasAutos : MetroFramework.Forms.MetroForm
    {
        public FrmFichasAutos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tiposDeDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDoc frm = new frmTipoDoc();
            frm.ShowDialog(this);
        }
    }
}
