using GestionVeterinariaServices.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.DAOs
{
    public class ClientesDAO : ConexionDAO
    {
        public void InsertCliente(Cliente cliente)
        {
            string sQuery = "INSERT INTO Clientes (Nombre, DNI) VALUES (@Nombre, @DNI)";

            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@DNI", cliente.DNI);

            cmd.CommandText = sQuery;

            cmd.ExecuteNonQuery();

            connect.Close();
        }
    }

    public List<Cliente> GetAllClientes()
    {
        List<Cliente> listaClientes = new List<Cliente>();

        var connect = this.GetConexion();

        SqlCommand cmd = connect.CreateCommand();

        cmd.CommandText = "SELECT ClienteID, Nombre, DNI FROM Clientes";

        SqlDataReader lector = cmd.ExecuteReader();

        while (lector.Read())
        {
            Cliente cliente = new Cliente()
            {
                Nombre = lector.GetString(1),
                DNI = lector.GetInt32(2)
            };
            listaClientes.Add(cliente);
        }

        connect.Close();

        return listaClientes;
    }
}
