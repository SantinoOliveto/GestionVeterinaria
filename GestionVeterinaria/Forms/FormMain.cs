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
        private List<Cliente> _listaClientes;
        public FormMain()
        {
            InitializeComponent();
            this._clientesDAO = new ClientesDAO();
            this._listaClientes = new List<Cliente>();
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
                LimpiarCampos();
                return;
            }


            try
            {
                string sDNI = txtBoxDNICliente.Text;
                int DNI = int.Parse(sDNI);
                string nombre = txtBoxNombreCliente.Text;

                if (DNI < 0)
                {
                    throw new DNINegativoException(sDNI);
                }

                Cliente cliente = new Cliente(DNI, nombre);
                _listaClientes = _clientesDAO.GetAllClientes();

                foreach (Cliente clienteB in _listaClientes)
                {
                    if (cliente.DNI == clienteB.DNI)
                    {
                        MessageBox.Show($"El DNI {clienteB.DNI} ya existe");
                        LimpiarCampos();

                    }
                }
                _clientesDAO.InsertCliente(cliente);
                LimpiarCampos();
            }
            catch (FormatException fEX)
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                LimpiarCampos();
            }
            catch (DNINegativoException DNegEx)
            {
                MessageBox.Show("El DNI no puede ser negativo");
                LimpiarCampos();
            }

        }

        public void LimpiarCampos()
        {
            this.txtBoxDNICliente.Clear();
            this.txtBoxNombreCliente.Clear();
        }
    }
}
