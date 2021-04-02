using ProyectoTallerAutos.Entidades.DTOs.Localidad;
using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Clientes;
using ProyectoTallerAutos.Servicios.Servicios.Clientes.Interfaces;
using ProyectoTallerAutos.Windows.Clientes.FormAE;
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
    public partial class frmLocalidades : MetroFramework.Forms.MetroForm
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        List<LocalidadDto> lista;
        private IServicioLocalidades _servicio;
        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioLocalidades();
                lista = _servicio.GetLista();
                MostrarEnGrilla();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void MostrarEnGrilla()
        {
            dgvLocalidades.Rows.Clear();
            foreach (var localidadDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, localidadDto);
                AgregarFila(r);
            }
        }
        private void AgregarFila(DataGridViewRow r)
        {
            dgvLocalidades.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, LocalidadDto localidadDto)
        {
            r.Cells[cmnLocalidad.Index].Value = localidadDto.NombreLocalidad;
            r.Cells[cmnProvincia.Index].Value = localidadDto.Nomprovincia;
            r.Tag = localidadDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvLocalidades);
            return r;
        }

        private void btnNuevo_Click(object sender, EventArgs e)//Hacer boton Nuevo
        {
            FrmLocalidadesAE frm = new FrmLocalidadesAE();
            frm.Text = "Nueva Localidad";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Localidad localidad = frm.GetLocalidad();
                    if (!_servicio.Existe(localidad))
                    {
                        _servicio.Guardar(localidad);
                        LocalidadDto localidadDto = new LocalidadDto
                        {
                            LocalidadId = localidad.LocalidadId,
                            NombreLocalidad = localidad.NombreLocalidad,
                            Nomprovincia = localidad.provincia.NombreProvincia

                        };
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, localidadDto);
                        AgregarFila(r);
                        MessageBox.Show("Registro Agregado", "mensaje", MessageBoxButtons.OK,
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

                    MessageBox.Show(excepcion.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLocalidades.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvLocalidades.SelectedRows[0];
                LocalidadDto localidadDto = (LocalidadDto)r.Tag;
                Localidad localidad = new Localidad();
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja la Localidad: {localidadDto.NombreLocalidad}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        //if (!_servicio.EstaRelacionado(localidad))
                        //{
                            _servicio.Borrar(localidadDto.LocalidadId);
                            dgvLocalidades.Rows.Remove(r);
                            MessageBox.Show("Registro Borrado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //}
                        //else
                        //{
                        //    MessageBox.Show("Localidad con Clientes \nBaja Denegada", "Error",
                        //        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //}
                    }
                    catch (Exception ex)
                    {

                        if (ex.Message.Contains("REFERENCE"))
                        {
                            MessageBox.Show("Localidad con Clientes \nBaja Denegada", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLocalidades.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvLocalidades.SelectedRows[0];
                LocalidadDto localidadDto = (LocalidadDto)r.Tag;
                LocalidadDto localidadDtoAux = (LocalidadDto)localidadDto.Clone();
                FrmLocalidadesAE frm = new FrmLocalidadesAE();
                Localidad localidad = _servicio.GetLocalidadesPorId(localidadDto.LocalidadId);
                frm.Text = "Editar Localidad";
                frm.SetLocalidad(localidad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        localidad = frm.GetLocalidad();
                        if (!_servicio.Existe(localidad))
                        {
                            _servicio.Guardar(localidad);
                            localidadDto = new LocalidadDto
                            {
                                LocalidadId = localidad.LocalidadId,
                                NombreLocalidad = localidad.NombreLocalidad,
                                Nomprovincia = localidad.provincia.NombreProvincia,
                            };
                            SetearFila(r, localidadDto);
                            MessageBox.Show("Registro Editado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            SetearFila(r, localidadDtoAux);
                            MessageBox.Show("Registro Duplicado \nAlta Denegada", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    catch (Exception exception)
                    {
                        SetearFila(r, localidadDtoAux);
                        MessageBox.Show(exception.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }
    }
}
