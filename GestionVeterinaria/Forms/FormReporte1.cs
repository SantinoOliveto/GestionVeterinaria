using GestionVeterinariaServices.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVeterinaria.Forms
{
    public partial class FormReporte1 : Form
    {
        private readonly AnimalesDAO _animalesDAO;
        public FormReporte1()
        {
            InitializeComponent();
            this._animalesDAO = new AnimalesDAO();
        }

        private void btnFiltrarEdades_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtBoxEdad1.Text) || String.IsNullOrEmpty(txtBoxEdad2.Text)) 
            {
                MessageBox.Show("Faltan rellenar campos");
                txtBoxEdad1.Clear();
                txtBoxEdad2.Clear();
                return;
            }

            string sEdad1 = txtBoxEdad1.Text;
            int edad1 = int.Parse(sEdad1);
            string sEdad2 = txtBoxEdad2.Text;
            int edad2 = int.Parse(sEdad2);

            if(edad1 > edad2)
            {
                MessageBox.Show("La primer edad tiene que ser menor que la segunda.");
                txtBoxEdad1.Clear();
                txtBoxEdad2.Clear();
                return;
            }

            DataTable dataTable = new DataTable();

            dataTable = _animalesDAO.GetPrimerReporte(edad1, edad2);

            dgvInforme1.DataSource = dataTable;

            txtBoxEdad1.Clear();
            txtBoxEdad2.Clear();
        }

        private void btnVolverMenu1_Click(object sender, EventArgs e)
        {
            var mainForm = new FormMain();
            mainForm.Show();
            this.Hide();
        }
    }
}
