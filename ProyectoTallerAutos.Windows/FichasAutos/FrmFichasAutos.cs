using ProyectoTallerAutos.Entidades.DTOs.FichaAuto;
using ProyectoTallerAutos.Servicios.Servicios.FichasAutos;
using ProyectoTallerAutos.Servicios.Servicios.FichasAutos.Interfaces;
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
        private IServicioFichaAutos _servicios;
        private List<FichaAutoDto> _lista;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void FrmFichasAutos_Load(object sender, EventArgs e)
        {
            try
            {
                _servicios = new ServicioFichaAutos();
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
            dgvFichasAutos.Rows.Clear();
            foreach (var FichaAutoDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, FichaAutoDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvFichasAutos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, FichaAutoDto fichaAutoDto)
        {
            r.Cells[cmnNombreCli.Index].Value = fichaAutoDto.NombreCliente;
            r.Cells[cmnApellidoCli.Index].Value = fichaAutoDto.ApellidoCliente;
            r.Cells[cmnNumDoc.Index].Value = fichaAutoDto.nroDoc;
            r.Cells[cmnMarca.Index].Value = fichaAutoDto.marca;
            r.Cells[cmnTipoVehiculo.Index].Value = fichaAutoDto.tipoVehic;
            r.Cells[cmnModelo.Index].Value = fichaAutoDto.modelo;
            r.Cells[cmnPatente.Index].Value = fichaAutoDto.patente;
            r.Tag = fichaAutoDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvFichasAutos);
            return r;
        }
    }
    
}
