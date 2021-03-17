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
    public partial class frmClientes : MetroFramework.Forms.MetroForm
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades frm = new frmLocalidades();
            frm.ShowDialog(this);
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvincias frm = new frmProvincias();
            frm.ShowDialog(this);
        }

        private void tiposDeDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDoc frm = new frmTipoDoc();
            frm.ShowDialog(this);
        }
    }
}
