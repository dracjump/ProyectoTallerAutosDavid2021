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
    public partial class frmTipoDoc : MetroFramework.Forms.MetroForm
    {
        public frmTipoDoc()
        {
            InitializeComponent();
        }
        private List<TipoDocumento> _lista;
        private IServicioTipoDoc _servicio;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTipoDoc_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioTipoDoc();
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
            dgvTipoDoc.Rows.Clear();
            foreach (var tipoDocumento in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipoDocumento);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvTipoDoc.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDocumento tipoDocumento)
        {
            r.Cells[cmnTipoDoc.Index].Value = tipoDocumento.Descripcion;
            r.Tag = tipoDocumento;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvTipoDoc);
            return r;
        }
    }
}
