using GestionVeterinariaServices.Exceptions;
using GestionVeterinariaServices.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.DAOs 
{
    public class UsuariosDAO : ConexionDAO
    {
        public void InsertUsuario (Usuario usuario)
        {
            string sQuery = "INSERT INTO Usuarios (Nombre, Clave) VALUES (@Nombre, @Clave)";

            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@Clave", usuario.Clave);

            cmd.CommandText = sQuery;

            cmd.ExecuteNonQuery();

            connect.Close();
        }

        public List<Usuario> GetAllUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            var connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "SELECT UsuarioID, Nombre, Clave FROM Usuarios";

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Usuario usuario = new Usuario()
                {
                    Nombre = lector.GetString(1),
                    Clave = lector.GetString(2)
                };
                listaUsuarios.Add(usuario);

                //Console.WriteLine($"{usuario.Nombre}, {usuario.Clave}");
            }

            //Console.ReadKey();
            connect.Close();

            return listaUsuarios;
        }

        public Usuario GetLoginUsuario(string nombre, string clave)
        {
            Usuario usuarioEncontrado = null;

            var connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = $"SELECT UsuarioID, Nombre, Clave FROM Usuarios WHERE Nombre = '{nombre}' AND Clave = '{clave}'";

            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read()){
                usuarioEncontrado = new Usuario()
                {
                    Nombre = lector.GetString(1),
                    Clave = lector.GetString(2)
                };

            }

            connect.Close();

            return usuarioEncontrado;
        }
    }
}

