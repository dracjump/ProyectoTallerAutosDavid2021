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
    public partial class frmMarcas : MetroFramework.Forms.MetroForm
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private List<MarcaAuto> _lista;
        private ServicioMarcas _servicio;

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioMarcas();
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
            dgvMarcas.Rows.Clear();
            foreach (var marca in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, marca);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvMarcas.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, MarcaAuto marca)
        {
            r.Cells[cmnMarcas.Index].Value = marca.NomMarca;
            r.Tag = marca;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvMarcas);
            return r;
        }
    }
}
