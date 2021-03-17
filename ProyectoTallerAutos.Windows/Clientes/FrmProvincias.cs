using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Clientes;
using ProyectoTallerAutos.Servicios.Servicios.Clientes.Interfaces;
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
    public partial class frmProvincias : MetroFramework.Forms.MetroForm
    {
        public frmProvincias()
        {
            InitializeComponent();
        }
        private IServicioProvincias _Servicio;
        private List<Provincia> _lista;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProvincias_Load(object sender, EventArgs e)
        {
            _Servicio = new ServicioProvincias();
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
            dgvProvincias.Rows.Clear();
            foreach (var provincia in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, provincia);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvProvincias.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Provincia provincia)
        {
            r.Cells[cmnProvincia.Index].Value = provincia.NombreProvincia;
            r.Tag = provincia;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvProvincias);
            return r;
        }
    }
}
