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

namespace ProyectoTallerAutos.Windows
{
    public partial class frmEstado : MetroFramework.Forms.MetroForm
    {
        public frmEstado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioEstados _Servicio;
        private List<Estado> _lista;

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            _Servicio = new ServicioEstados();
            try
            {
                _lista = _Servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exeption)
            {

                Console.WriteLine(exeption);
                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvEstados.Rows.Clear();
            foreach (var estado in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, estado);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvEstados.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Estado estado)
        {
            r.Cells[cmnEstados.Index].Value = estado.Descripcion;
            r.Tag = estado;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvEstados);
            return r;
        }
    }
}
