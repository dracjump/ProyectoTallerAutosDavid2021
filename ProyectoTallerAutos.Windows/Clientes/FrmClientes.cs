using ProyectoTallerAutos.Entidades.DTOs.Clientes;
using ProyectoTallerAutos.Servicios.Servicios.Clientes;
using ProyectoTallerAutos.Servicios.Servicios.Clientes.Interfaces;
using ProyectoTallerAutos.Windows.Clientes.FormAE;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoTallerAutos.Windows.Clientes
{
    public partial class frmClientes : MetroFramework.Forms.MetroForm
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private IServicioClientes _servicios;
        private List<ClienteDto> _lista;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
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

        private void tiposDeDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDoc frm = new frmTipoDoc();
            frm.ShowDialog(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmClientesAE frm = new FrmClientesAE();
            frm.ShowDialog(this);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                _servicios = new ServicioClientes();
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
            dgvClientes.Rows.Clear();
            foreach (var ClienteDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, ClienteDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvClientes.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, ClienteDto clienteDto)
        {
            r.Cells[cmnNombre.Index].Value = clienteDto.Nombre;
            r.Cells[cmnApellido.Index].Value = clienteDto.Apellido;
            r.Cells[cmnNDoc.Index].Value = clienteDto.NroDocumento;
            r.Cells[cmnDireccion.Index].Value = clienteDto.Direccion;
            r.Cells[cmnLocalidad.Index].Value = clienteDto.nomLocalidad;
            r.Cells[cmnTelFino.Index].Value = clienteDto.TelefonoFijo;
            r.Cells[cmnTelMovil.Index].Value = clienteDto.TelefonoMovil;
            r.Cells[cmnCorreoEl.Index].Value = clienteDto.CorrreoElectronico;
            r.Tag = clienteDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvClientes);
            return r;
        }
    }
}
