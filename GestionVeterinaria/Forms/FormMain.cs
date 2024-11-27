using GestionVeterinariaServices.DAOs;
using GestionVeterinariaServices.Exceptions;
using GestionVeterinariaServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVeterinaria.Forms
{
    public partial class FormMain : Form
    {
        private readonly ClientesDAO _clientesDAO;
        private readonly AnimalesDAO _animalesDAO;
        private readonly EspeciesDAO _especiesDAO;
        private List<Cliente> _listaClientes;
        private List<Especie> _listaEspecies;
        public FormMain()
        {
            InitializeComponent();
            this._clientesDAO = new ClientesDAO();
            this._listaClientes = new List<Cliente>();
            this._especiesDAO = new EspeciesDAO();
            this._listaEspecies = new List<Especie>();
            this._animalesDAO = new AnimalesDAO();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _listaClientes = _clientesDAO.GetAllClientes();
            cmbBoxCliente.DataSource = _listaClientes;

            _listaEspecies = _especiesDAO.GetAllEspecies();
            cmbBoxEspecie.DataSource = _listaEspecies;
        }

        public void LimpiarCampos1()
        {
            this.txtBoxDNICliente.Clear();
            this.txtBoxNombreCliente.Clear();
        }
        public void LimpiarCampos2()
        {
            this.txtBoxEdadMadurezEspecie.Clear();
            this.txtBoxNombreEspecie.Clear();
            this.txtBoxPesoPromedioEspecie.Clear();
        }

        public void LimpiarCampos3()
        {
            txtBoxNombreAnimal.Clear();
            txtBoxEdadAnimal.Clear();
            txtBoxPesoAnimal.Clear();
        }

        private void btnFormInforme1_Click(object sender, EventArgs e)
        {
            var infForm1 = new FormReporte1();
            infForm1.Show();
            this.Hide();
        }

        private void btnFormInforme2_Click(object sender, EventArgs e)
        {
            var infForm2 = new FormReporte2();
            infForm2.Show();
            this.Hide();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxNombreCliente.Text) || String.IsNullOrEmpty(txtBoxDNICliente.Text))
            {
                MessageBox.Show("Faltan rellenar campos.");
                LimpiarCampos1();
                return;
            }


            try
            {
                string sDNI = txtBoxDNICliente.Text.ToLower();
                int DNI = int.Parse(sDNI);
                string nombre = txtBoxNombreCliente.Text.ToLower();

                if (DNI < 0)
                {
                    throw new DNINegativoException(sDNI);
                }

                Cliente cliente = new Cliente(DNI, nombre);
                _listaClientes = _clientesDAO.GetAllClientes();
                cmbBoxCliente.DataSource = null;
                cmbBoxCliente.DataSource = _listaClientes;

                foreach (Cliente clienteB in _listaClientes)
                {
                    if (cliente.DNI == clienteB.DNI)
                    {
                        MessageBox.Show($"El DNI {clienteB.DNI} ya existe");
                        LimpiarCampos1();

                    }
                }
                _clientesDAO.InsertCliente(cliente);
                MessageBox.Show($"El cliente {cliente.DNI}, {cliente.Nombre} se cargo correctamente.");
                LimpiarCampos1();
            }
            catch (FormatException fEX)
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                LimpiarCampos1();
            }
            catch (DNINegativoException DNegEx)
            {
                MessageBox.Show("El DNI no puede ser negativo");
                LimpiarCampos1();
            }

        }



        private void btnAltaEspecie_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtBoxNombreEspecie.Text) || String.IsNullOrEmpty(txtBoxPesoPromedioEspecie.Text) || String.IsNullOrEmpty(txtBoxEdadMadurezEspecie.Text))
            {
                MessageBox.Show("Faltan rellenar campos.");
                LimpiarCampos2();
                return;
            }

            try
            {
                string nombre = txtBoxNombreEspecie.Text.ToLower();
                string sPesoPromedio = txtBoxPesoPromedioEspecie.Text.ToLower();
                string sEdadMad = txtBoxEdadMadurezEspecie.Text.ToLower();

                decimal PesoPromedio = decimal.Parse(sPesoPromedio);
                int EdadMad = int.Parse(sEdadMad);

                if (EdadMad <= 0)
                {
                    throw new EdadMadurezNegativaOCeroException(sEdadMad);
                }
                if (PesoPromedio <= 0)
                {
                    throw new PesoPromedioNegativoOCeroException(sPesoPromedio);
                }

                Especie especie = new Especie(nombre, EdadMad, PesoPromedio);
                _listaEspecies = _especiesDAO.GetAllEspecies();
                cmbBoxEspecie.DataSource = null;
                cmbBoxEspecie.DataSource = _listaEspecies;

                foreach (Especie especie1 in _listaEspecies)
                {
                    if(especie1.Nombre == nombre)
                    {
                        MessageBox.Show($"La especie de nombre {nombre} ya esta cargada en el sistema.");
                        LimpiarCampos2();
                        return;
                    }
                }
                _especiesDAO.InsertEspecie(especie);
                MessageBox.Show($"La especie {especie.Nombre} se cargo en el sistema.");
                LimpiarCampos2();
            }
            catch (EdadMadurezNegativaOCeroException EMex)
            {
                MessageBox.Show("La edad de madurez debe ser positiva");
                LimpiarCampos2();
            }
            catch (PesoPromedioNegativoOCeroException PPex)
            {
                MessageBox.Show("El peso promedio debe ser positivo");
                LimpiarCampos2();
            }

        }

        private void btnAltaAnimal_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxNombreAnimal.Text) || String.IsNullOrEmpty(txtBoxPesoAnimal.Text) || String.IsNullOrEmpty(txtBoxEdadAnimal.Text))
            {
                MessageBox.Show("Faltan rellenar campos.");
                LimpiarCampos3();
                return;
            }
            try
            {

                Cliente cliente = (Cliente)cmbBoxCliente.SelectedValue;
                Especie especie = (Especie)cmbBoxEspecie.SelectedValue;
                string nombre = txtBoxNombreAnimal.Text.ToLower();
                string sEdad = txtBoxEdadAnimal.Text;
                string sPeso = txtBoxPesoAnimal.Text;

                int Edad = int.Parse(sEdad);
                decimal Peso = decimal.Parse(sPeso);

                if (Edad <= 0)
                {
                    throw new EdadMadurezNegativaOCeroException(sEdad);
                }
                if (Peso <= 0)
                {
                    throw new PesoPromedioNegativoOCeroException(sPeso);
                }
                Animal animal = new Animal(cliente.DNI,nombre,Peso,Edad);
                _animalesDAO.InsertAnimal(animal);

            }
            catch (EdadMadurezNegativaOCeroException EMex)
            {
                MessageBox.Show("La edad del animal debe ser positiva.");
                LimpiarCampos3();
            }
            catch (PesoPromedioNegativoOCeroException PPex)
            {
                MessageBox.Show("El peso del animal debe ser positivo.");
                LimpiarCampos3();
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _listaClientes = _clientesDAO.GetAllClientes();
            cmbBoxCliente.DataSource = _listaClientes;

            _listaEspecies = _especiesDAO.GetAllEspecies();
            cmbBoxEspecie.DataSource = _listaEspecies;
        }
    }
}
