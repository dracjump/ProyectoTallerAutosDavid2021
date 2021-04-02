using ProyectoTallerAutos.Windows.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerAutos.Windows.FichasAutos
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



        private void FrmFichasAutos_Load(object sender, EventArgs e)
        {

        }
    }
}
