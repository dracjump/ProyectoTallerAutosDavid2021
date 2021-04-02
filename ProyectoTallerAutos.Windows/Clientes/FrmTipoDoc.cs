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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmTiposDocAE frm = new FrmTiposDocAE();
            frm.Text = "Agregar Tipo Documento";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoDocumento tipo = frm.GetTipo();
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
            if (dgvTipoDoc.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvTipoDoc.SelectedRows[0];
                TipoDocumento tipo = (TipoDocumento)r.Tag;
                TipoDocumento tipoAux = (TipoDocumento)tipo.Clone();
                FrmTiposDocAE frm = new FrmTiposDocAE();
                frm.Text = "Editar Tipo Documento";
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
                            MessageBox.Show($"Registro: {tipo.Descripcion} Editado");
                        }
                        //dgvTipoDoc.Rows.Remove(r);
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
            if (dgvTipoDoc.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvTipoDoc.SelectedRows[0];
                TipoDocumento tipoDoc = (TipoDocumento)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"Desea dar de baja el Tipo: {tipoDoc.Descripcion} ?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!_servicio.EstaRelacionado(tipoDoc))
                        {
                            _servicio.Borrar(tipoDoc.TipoDeDocumentoId);
                            dgvTipoDoc.Rows.Remove(r);
                            MessageBox.Show($"Registro {tipoDoc.Descripcion} fue Eliminado");
                        }
                        else
                        {
                            MessageBox.Show("Tipo de documento con Cliente \nBaja Denegada", "Error",
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
