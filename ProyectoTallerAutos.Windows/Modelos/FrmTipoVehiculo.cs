using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Modelos;
using ProyectoTallerAutos.Windows.Modelos.FormAE;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmTiposAE frm = new FrmTiposAE();
            frm.Text = "Agregar Tipo";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoVehiculo tipo = frm.GetTipo();
                    if (!_servicio.Existe(tipo))
                    {
                        _servicio.Guardar(tipo);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, tipo);
                        AgregarFila(r);
                        MessageBox.Show(this, $"Registro {tipo.Descripcion} Agregado",
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
            if (dgvTipoVehiculo.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvTipoVehiculo.SelectedRows[0];
                TipoVehiculo tipo = (TipoVehiculo)r.Tag;
                TipoVehiculo tipoAux = (TipoVehiculo)tipo.Clone();
                FrmTiposAE frm = new FrmTiposAE();
                frm.Text = "Editar Tipo";
                frm.SetTipo(tipo);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tipo = frm.GetTipo();
                        if (!_servicio.Existe(tipo))
                        {
                            _servicio.Guardar(tipo);
                            SetearFila(r, tipo);
                            MessageBox.Show($"Registro {tipo.Descripcion} Editado");
                        }
                        //dgvTipoVehiculo.Rows.Remove(r);
                        //MostrarEnGrilla();
                        else
                        {
                            SetearFila(r, tipoAux);
                            MessageBox.Show($"Registro {tipo.Descripcion} Ya existe!");
                        }
                    }
                    catch (Exception exepcion)
                    {
                        SetearFila(r, tipoAux);
                        MessageBox.Show(this, exepcion.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoVehiculo.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvTipoVehiculo.SelectedRows[0];
                TipoVehiculo tipo = (TipoVehiculo)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"Desea dar de baja el Tipo: {tipo.Descripcion} ?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!_servicio.EstaRelacionado(tipo))
                        {
                            _servicio.Borrar(tipo.TipoVehiculoId);
                            MessageBox.Show($"Registro {tipo.Descripcion} Eliminado");
                            dgvTipoVehiculo.Rows.Remove(r);
                        }
                        else
                        {
                            MessageBox.Show("Tipo de Vehiculo con Modelo \nBaja Denegada", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    catch (Exception exepcion)
                    {

                        MessageBox.Show(this, exepcion.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }


                }

            }
        }
    }
}
