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
    public partial class FormReporte2 : Form
    {
        private readonly AnimalesDAO _animalesDAO;
        public FormReporte2()
        {
            InitializeComponent();
            this._animalesDAO = new AnimalesDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVolverMenu2_Click(object sender, EventArgs e)
        {
            var mainForm = new FormMain();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
            this.Hide();
        }

        private void btnMostrarCliente_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = _animalesDAO.GetSegundoReporte();

            dgvInforme2.DataSource = dataTable;
        }
    }
}
