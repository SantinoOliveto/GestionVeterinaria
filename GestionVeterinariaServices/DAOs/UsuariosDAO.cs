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
    public class UsuariosDAO
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VeterinariaDB"].ConnectionString;

        public void CrearUsuario(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuario (nombres, claves) VALUES (@Nombres, @Clave)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombres", usuario.Nombre);
                command.Parameters.AddWithValue("@Clave", HashPassword(usuario.Clave));

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Usuario AutenticarUsuario(string nombre, string clave)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE nombres = @Nombres AND claves = @Clave";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombres", nombre);
                command.Parameters.AddWithValue("@Clave", HashPassword(clave));

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Nombre = reader["nombres"].ToString()
                        };
                    }
                    else
                    {
                        throw new AutenticacionFallidaException("Usuario o clave incorrecta.");
                    }
                }
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        
    }
}
