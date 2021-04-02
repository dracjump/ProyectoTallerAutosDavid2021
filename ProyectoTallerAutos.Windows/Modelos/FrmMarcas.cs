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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMarcasAE frm = new frmMarcasAE();
            frm.Text = "Agregar Marca";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    MarcaAuto marca = frm.GetMarca();
                    if (!_servicio.Existe(marca))
                    {
                        _servicio.Guardar(marca);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, marca);
                        AgregarFila(r);
                        MessageBox.Show(this, $"Registro {marca.NomMarca} Agregado",
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
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvMarcas.SelectedRows[0];
                MarcaAuto marca = (MarcaAuto)r.Tag;
                MarcaAuto marcaAux =(MarcaAuto) marca.Clone();
                frmMarcasAE frm = new frmMarcasAE();
                frm.Text = "Editar Marca";
                frm.SetMarca(marca);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        marca = frm.GetMarca();
                        if (!_servicio.Existe(marca))
                        {
                            _servicio.Guardar(marca);
                            SetearFila(r, marca);
                            MessageBox.Show($"Registro {marca.NomMarca} Editado");
                        }
                        //dgvMarcas.Rows.Remove(r);
                        //MostrarEnGrilla();
                        else
                        {
                            SetearFila(r, marcaAux);
                            MessageBox.Show($"Registro {marca.NomMarca} Ya existe!");
                        }

                    }
                    catch (Exception exepcion)
                    {
                        SetearFila(r, marcaAux);
                        MessageBox.Show(this, exepcion.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvMarcas.SelectedRows[0];
                MarcaAuto marca = (MarcaAuto)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"Desea dar de baja la marca: {marca.NomMarca} ?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!_servicio.EstaRelacionado(marca))
                        {
                            _servicio.Borrar(marca.MarcaId);
                            dgvMarcas.Rows.Remove(r);
                            MessageBox.Show($"Registro {marca.NomMarca} fue Eliminado");
                        }
                        else
                        {
                            MessageBox.Show("Marca con Modelo \nBaja Denegada", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        }
    }
}
