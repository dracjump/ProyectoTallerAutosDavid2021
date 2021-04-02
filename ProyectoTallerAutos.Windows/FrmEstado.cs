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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEstadosAE frm = new FrmEstadosAE();
            frm.Text = "Agregar Estado";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Estado estado = frm.GetEstado();
                    if (!_Servicio.Existe(estado))
                    {
                        _Servicio.Guardar(estado);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, estado);
                        AgregarFila(r);
                        MessageBox.Show(this, $"Registro {estado.Descripcion} Agregado",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro Existente", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(this, excepcion.Message, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEstados.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvEstados.SelectedRows[0];
                Estado estado = (Estado)r.Tag;
                Estado estadoAux = (Estado)estado.Clone();
                FrmEstadosAE frm = new FrmEstadosAE();
                frm.Text = "Editar Estado";
                frm.SetEstado(estado);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        estado = frm.GetEstado();
                        if (!_Servicio.Existe(estado))
                        {
                            _Servicio.Guardar(estado);
                            SetearFila(r, estado);
                            MessageBox.Show($"Registro {estado.Descripcion} Editado");
                        }

                        else
                        {
                            SetearFila(r, estadoAux);
                            MessageBox.Show($"Registro {estado.Descripcion} Ya existe!");
                        }

                    }
                    catch (Exception exepcion)
                    {
                        SetearFila(r, estadoAux);
                        MessageBox.Show(this, exepcion.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstados.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvEstados.SelectedRows[0];
                Estado estado = (Estado)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"Desea dar de baja el estado : {estado.Descripcion} ?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        //if (!_Servicio.EstaRelacionado(estado))
                        //{
                        _Servicio.Borrar(estado.EstadoId);
                        dgvEstados.Rows.Remove(r);
                        MessageBox.Show($"Registro {estado.Descripcion} fue Eliminado");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Estado asociado \nBaja Denegada", "Error",
                        //        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //}


                    }
                    catch (Exception excepcion)
                    {

                        MessageBox.Show(this, excepcion.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }

            }
        }
    }
}
