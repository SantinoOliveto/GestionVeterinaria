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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxDNICliente_TextChanged(object sender, EventArgs e)
        {

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
    }
}
