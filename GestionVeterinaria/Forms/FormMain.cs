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
        private ClientesDAO _clientesDAO;
        private AnimalesDAO _animalesDAO;
        private EspeciesDAO _especiesDAO;
        private List<Cliente> _listaClientes;
        private List<Especie> _listaEspecies;

        public void CrearDaos()
        {
            this._animalesDAO = new AnimalesDAO();
            this._especiesDAO = new EspeciesDAO();
            this._clientesDAO = new ClientesDAO();
        }

        private void CrearListas()
        {
            this._listaClientes = new List<Cliente>();
            this._listaEspecies = new List<Especie>();
        }
        public FormMain()
        {
            InitializeComponent();
            CrearDaos();
            CrearListas();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _listaClientes = _clientesDAO.GetAllClientes();
            cmbBoxCliente.DataSource = _listaClientes;

            _listaEspecies = _especiesDAO.GetAllEspecies();
            cmbBoxEspecie.DataSource = _listaEspecies;
        }

        public void LimpiarCamposCliente()
        {
            this.txtBoxDNICliente.Clear();
            this.txtBoxNombreCliente.Clear();
        }
        public void LimpiarCamposEspecie()
        {
            this.txtBoxEdadMadurezEspecie.Clear();
            this.txtBoxNombreEspecie.Clear();
            this.txtBoxPesoPromedioEspecie.Clear();
        }

        public void LimpiarCamposAnimal()
        {
            this.txtBoxNombreAnimal.Clear();
            this.txtBoxEdadAnimal.Clear();
            this.txtBoxPesoAnimal.Clear();
        }

        private void btnFormInforme1_Click(object sender, EventArgs e)
        {
            var infForm1 = new FormReporte1();
            infForm1.Show();
            infForm1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void btnFormInforme2_Click(object sender, EventArgs e)
        {
            var infForm2 = new FormReporte2();
            infForm2.Show();
            infForm2.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxNombreCliente.Text) || String.IsNullOrEmpty(txtBoxDNICliente.Text))
            {
                MessageBox.Show("Faltan rellenar campos.");
                LimpiarCamposCliente();
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
                        LimpiarCamposCliente();

                    }
                }
                _clientesDAO.InsertCliente(cliente);
                MessageBox.Show($"El cliente {cliente.DNI}, {cliente.Nombre} se cargo correctamente.");
                LimpiarCamposCliente();
            }
            catch (FormatException fEX)
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                LimpiarCamposCliente();
            }
            catch (DNINegativoException DNegEx)
            {
                MessageBox.Show("El DNI no puede ser negativo");
                LimpiarCamposCliente();
            }

        }



        private void btnAltaEspecie_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtBoxNombreEspecie.Text) || String.IsNullOrEmpty(txtBoxPesoPromedioEspecie.Text) || String.IsNullOrEmpty(txtBoxEdadMadurezEspecie.Text))
            {
                MessageBox.Show("Faltan rellenar campos.");
                LimpiarCamposEspecie();
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
                    throw new EdadNegativaOCeroException(sEdadMad);
                }
                if (PesoPromedio <= 0)
                {
                    throw new PesoPromedioNegativoOCeroException(sPesoPromedio);
                }

                foreach (Especie especie1 in _listaEspecies)
                {
                    if (especie1.Nombre == nombre)
                    {
                        MessageBox.Show($"La especie de nombre {nombre} ya esta cargada en el sistema.");
                        LimpiarCamposEspecie();
                        return;
                    }
                }

                Especie especie = new Especie(nombre, EdadMad, PesoPromedio);
                _listaEspecies = _especiesDAO.GetAllEspecies();
                cmbBoxEspecie.DataSource = null;
                cmbBoxEspecie.DataSource = _listaEspecies;

                _especiesDAO.InsertEspecie(especie);
                MessageBox.Show($"La especie {especie.Nombre} se cargo en el sistema.");
                LimpiarCamposEspecie();
            }
            catch (EdadNegativaOCeroException EMex)
            {
                MessageBox.Show("La edad de madurez debe ser positiva");
                LimpiarCamposEspecie();
            }
            catch (PesoPromedioNegativoOCeroException PPex)
            {
                MessageBox.Show("El peso promedio debe ser positivo");
                LimpiarCamposEspecie();
            }

        }

        private void btnAltaAnimal_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxNombreAnimal.Text) || String.IsNullOrEmpty(txtBoxPesoAnimal.Text) || String.IsNullOrEmpty(txtBoxEdadAnimal.Text))
            {
                MessageBox.Show("Faltan rellenar campos.");
                LimpiarCamposAnimal();
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
                    throw new EdadNegativaOCeroException(sEdad);
                }
                if (Peso <= 0)
                {
                    throw new PesoPromedioNegativoOCeroException(sPeso);
                }
                Animal animal = new Animal(cliente.DNI,especie.Id,nombre,Peso,Edad);
                _animalesDAO.InsertAnimal(animal);
                MessageBox.Show($"El animal {animal.Nombre} se cargo en el sistema.");
                LimpiarCamposAnimal();
            }
            catch (EdadNegativaOCeroException EMex)
            {
                MessageBox.Show("La edad del animal debe ser positiva.");
                LimpiarCamposAnimal();
            }
            catch (PesoPromedioNegativoOCeroException PPex)
            {
                MessageBox.Show("El peso del animal debe ser positivo.");
                LimpiarCamposAnimal();
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
