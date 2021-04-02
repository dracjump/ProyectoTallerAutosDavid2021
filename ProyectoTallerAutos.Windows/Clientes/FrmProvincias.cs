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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProvinciasAE frm = new FrmProvinciasAE();
            frm.Text = "Agregar Provincia";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Provincia provincia = frm.GetProvincia();
                    if (!_Servicio.Existe(provincia))
                    {
                        _Servicio.Guardar(provincia);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, provincia);
                        AgregarFila(r);
                        MessageBox.Show(this, $"Registro '{provincia.NombreProvincia}'Agregado",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Registro {provincia.NombreProvincia} Existente", "Error", MessageBoxButtons.OK,
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
            if (dgvProvincias.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvProvincias.SelectedRows[0];
                Provincia provincia = (Provincia)r.Tag;
                Provincia provinciaAux = (Provincia)provincia.Clone();
                FrmProvinciasAE frm = new FrmProvinciasAE();
                frm.Text = "Editar Provincia";
                frm.SetProvincia(provincia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        provincia = frm.GetProvincia();
                        if (!_Servicio.Existe(provincia))
                        {
                            _Servicio.Guardar(provincia);
                            SetearFila(r, provincia);
                            MessageBox.Show($"Registro: {provincia.NombreProvincia} Editado");
                        }
                        //dgvProvincias.Rows.Remove(r);
                        //MostrarDatosEnGrilla();
                        else
                        {
                            SetearFila(r, provinciaAux);
                            MessageBox.Show($"Registro {provincia.NombreProvincia} Ya existe!");
                        }

                    }
                    catch (Exception exepcion)
                    {
                        SetearFila(r, provinciaAux);
                        MessageBox.Show(this, exepcion.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProvincias.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvProvincias.SelectedRows[0];
                Provincia provincia = (Provincia)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"Desea dar de baja la Provincia: {provincia.NombreProvincia} ?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!_Servicio.EstaRelacionado(provincia))
                        {
                            _Servicio.Borrar(provincia.ProvinciaId);
                            dgvProvincias.Rows.Remove(r);
                            MessageBox.Show($"Registro {provincia.NombreProvincia} fue Eliminado");
                        }
                        else
                        {
                            MessageBox.Show("Provincia con Localidad \nBaja Denegada", "Error",
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
