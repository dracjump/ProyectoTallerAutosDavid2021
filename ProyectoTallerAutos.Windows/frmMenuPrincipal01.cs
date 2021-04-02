using ProyectoTallerAutos.Windows.Clientes;
using ProyectoTallerAutos.Windows.FichasAutos;
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

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDoc frm = new frmTipoDoc();
            frm.ShowDialog(this);
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

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas frm = new frmMarcas();
            frm.ShowDialog(this);
        }

        private void tiposDeViehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoVehiculo frm = new frmTipoVehiculo();
            frm.ShowDialog(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFichaAutos_Click(object sender, EventArgs e)
        {
            FrmFichasAutos frm = new FrmFichasAutos();
            frm.ShowDialog(this);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstado frm = new frmEstado();
            frm.ShowDialog(this);
        }

        private void fichaDeAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFichasAutos frm = new FrmFichasAutos();
            frm.ShowDialog(this);
        }
    }
}
