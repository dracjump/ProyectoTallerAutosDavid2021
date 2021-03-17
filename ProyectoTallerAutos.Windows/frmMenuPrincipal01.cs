using ProyectoTallerAutos.Windows.Clientes;
using ProyectoTallerAutos.Windows.Modelos;
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
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.ShowDialog(this);
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            frmModelos frm = new frmModelos();
            frm.ShowDialog(this);
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            frmEstado frm = new frmEstado();
            frm.ShowDialog(this);
        }
    }
}
