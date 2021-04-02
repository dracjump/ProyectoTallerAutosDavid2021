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

namespace ProyectoTallerAutos.Windows.Clientes.FormAE
{
    public partial class FrmLocalidadesAE : MetroFramework.Forms.MetroForm
    {
        public FrmLocalidadesAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosLocalidades();
            if (localidad!=null)
            {
                txbLocalidad.Text = localidad.NombreLocalidad;
                cbxProvincias.SelectedValue = localidad.provincia.ProvinciaId;
            }
        }

        //private void FrmMarcasAE_Load(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    CargarDatosLocalidades();

        //}

        private void CargarDatosLocalidades()
        {
            IServicioProvincias servicioProv = new ServicioProvincias();
            List<Provincia> listaProv = servicioProv.GetLista();
            var defaultProv = new Provincia() { ProvinciaId = 0, NombreProvincia = "<<Seleccione Provincia>>" };
            listaProv.Insert(0, defaultProv);
            cbxProvincias.DataSource = listaProv;
            cbxProvincias.ValueMember = "ProvinciaId";
            cbxProvincias.DisplayMember = "NombreProvincia";
            cbxProvincias.SelectedIndex = 0;
            //if (localidad != null)
            //{
            //    txbLocalidad.Text = localidad.NombreLocalidad;
            //    cbxProvincias.SelectedValue = localidad.provincia.ProvinciaId;

            //}
        }

        private Localidad localidad;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        //internal void SetTipo(Localidad localidad)
        //{
        //    this.localidad = localidad;
        //}

        internal Localidad GetLocalidad()
        {
            return localidad;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (localidad == null)
                {
                    localidad = new Localidad();
                }
                localidad.NombreLocalidad = txbLocalidad.Text;
                localidad.provincia = (Provincia)cbxProvincias.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txbLocalidad.Text.Trim()) &&
                string.IsNullOrWhiteSpace(txbLocalidad.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txbLocalidad, "Debe ingresar una Localidad");
            }
            if (cbxProvincias.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cbxProvincias, "Debe seleccionar una Provincia");
            }
            return valido;
        }

        internal void SetLocalidad(Localidad localidad)
        {
            this.localidad = localidad;
        }

        private void FrmLocalidadesAE_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarProvincia_Click(object sender, EventArgs e)
        {
            FrmProvinciasAE frm = new FrmProvinciasAE();
            frm.ShowDialog(this);
        }
    }
}
