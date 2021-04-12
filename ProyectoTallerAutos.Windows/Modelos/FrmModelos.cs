using ProyectoTallerAutos.Entidades.DTOs.Modelos;
using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Modelos;
using ProyectoTallerAutos.Servicios.Servicios.Modelos.Interfaces;
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
        private IServicioModelos _servicios;
        private List<ModeloDto> _lista;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmModelos_Load(object sender, EventArgs e)
        {
            try
            {
                _servicios = new ServicioModelos();
                _lista = _servicios.GetLista();
                MostrarEnGrilla();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void MostrarEnGrilla()
        {
            dgvModelos.Rows.Clear();
            foreach (var modeloDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, modeloDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvModelos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, ModeloDto modeloDto)
        {
            r.Cells[cmnMarcas.Index].Value = modeloDto.marcaAuto ;
            r.Cells[cmnTipoVehiculo.Index].Value = modeloDto.tipoVehiculo;
            r.Cells[cmnModelo.Index].Value = modeloDto.nomModelo;
            r.Tag = modeloDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvModelos);
            return r;
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
