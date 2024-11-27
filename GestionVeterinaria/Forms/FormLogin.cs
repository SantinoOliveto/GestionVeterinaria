using GestionVeterinaria.Forms;
using GestionVeterinariaServices.DAOs;
using GestionVeterinariaServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVeterinaria
{
    public partial class FormLogin : Form
    {
        private readonly UsuariosDAO _usuariosDAO;
        private List<Usuario> _listaUsuarios;
        public FormLogin()
        {
            InitializeComponent();
            this._usuariosDAO = new UsuariosDAO();
            this._listaUsuarios = new List<Usuario>();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LimpiarCamposRegistro()
        {
            txtBoxNombreUsuario.Clear();
            txtBoxClaveUsuario.Clear();
            txtBoxRepetirClaveUsuario.Clear();
        }

        private void LimpiarCamposLogin()
        {
            txtBoxUsuarioLogin.Clear();
            txtBoxClaveLogin.Clear();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxNombreUsuario.Text) || String.IsNullOrEmpty(txtBoxClaveUsuario.Text) || String.IsNullOrEmpty(txtBoxRepetirClaveUsuario.Text))
            {
                MessageBox.Show("Faltan rellenar campos.");
                LimpiarCamposRegistro();
                return;
            }

            if (txtBoxClaveUsuario.Text != txtBoxRepetirClaveUsuario.Text)
            {
                MessageBox.Show("Las claves deben ser iguales.");
                txtBoxClaveUsuario.Clear();
                txtBoxRepetirClaveUsuario.Clear();
                return;
            }

            string nombre = txtBoxNombreUsuario.Text.ToLower();
            string clave = txtBoxClaveUsuario.Text.ToLower();

            _listaUsuarios = _usuariosDAO.GetAllUsuarios();

            foreach (Usuario usuario in _listaUsuarios)
            {
                if (usuario.Nombre.ToLower() == nombre)
                {
                    MessageBox.Show($"Ya existe el usuario: {usuario.Nombre}.");
                    LimpiarCamposRegistro();
                    return;
                }
            }

            Usuario nUsuario = new Usuario(nombre, clave);

            _usuariosDAO.InsertUsuario(nUsuario);

            MessageBox.Show("El usuario se registro correctamente");

            LimpiarCamposRegistro();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxUsuarioLogin.Text) || String.IsNullOrEmpty(txtBoxClaveLogin.Text))
            {
                MessageBox.Show("Faltan rellenar campos.");
                LimpiarCamposLogin();
                return;
            }

            string nombre = txtBoxUsuarioLogin.Text.ToLower();
            string clave = txtBoxClaveLogin.Text.ToLower();

            _listaUsuarios = _usuariosDAO.GetAllUsuarios();

            foreach (Usuario usuario in _listaUsuarios)
            {
                if (usuario.Nombre.ToLower() == nombre && usuario.Clave.ToLower() == clave)
                {
                    MessageBox.Show("Se inicio sesion correctamente.");
                    var mainForm = new FormMain();
                    mainForm.StartPosition = FormStartPosition.CenterScreen;
                    mainForm.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("El usuario o contraseña no coinciden.");
            LimpiarCamposLogin();
        }
        
    }
}
