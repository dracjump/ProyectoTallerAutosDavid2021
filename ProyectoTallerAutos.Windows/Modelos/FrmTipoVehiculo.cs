using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Modelos;
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
        private List<TipoVehiculo> _lista;
        private ServicioTipoVehiculos _servicio;
        private void FrmModelos_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioTipoVehiculos();
                _lista = _servicio.GetLista();
                MostrarEnGrilla();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void MostrarEnGrilla()
        {
            dgvTipoVehiculo.Rows.Clear();
            foreach (var tipoVehiculo in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipoVehiculo);
                AgregarFila(r);

            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvTipoVehiculo.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoVehiculo tipoVehiculo)
        {
            r.Cells[cmnTipoVehiculo.Index].Value = tipoVehiculo.Descripcion;
            r.Tag = tipoVehiculo;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvTipoVehiculo);
            return r;
        }
    }
}
