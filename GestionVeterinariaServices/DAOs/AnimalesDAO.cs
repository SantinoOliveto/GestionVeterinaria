using GestionVeterinariaServices.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.DAOs
{
    public class AnimalesDAO : ConexionDAO
    {
        public List<Animal> GetAllAnimales()
        {
            List<Animal> listaAnimales = new List<Animal>();

            var connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "SELECT AnimalID, Nombre, Peso, Edad, ClienteDNI, EspecieID FROM Animales";

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Animal animal = new Animal()
                {
                    Nombre = lector.GetString(1),  
                    Peso = lector.GetDecimal(2),    
                    Edad = lector.GetInt32(3),      
                    ClienteDNI = lector.GetInt32(4), 
                    EspecieID = lector.GetInt32(5)

                };

                listaAnimales.Add(animal);
            }
            connect.Close();

            return listaAnimales;
        }

        public void InsertAnimal(Animal animal)
        {
            string sQuery = $"INSERT INTO Animales" +
                $"(Nombre, Peso, Edad, ClienteDNI, EspecieID)" +
                $" VALUES (@Nombre, @Peso, @Edad, @ClienteDNI, @EspecieID)";

            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.Parameters.AddWithValue("@Nombre", animal.Nombre);
            cmd.Parameters.AddWithValue("@Peso", animal.Peso);
            cmd.Parameters.AddWithValue("@Edad", animal.Edad);
            cmd.Parameters.AddWithValue("@ClienteDNI" , animal.ClienteDNI);
            cmd.Parameters.AddWithValue("@EspecieID", animal.EspecieID);


            cmd.CommandText = sQuery;

            cmd.ExecuteNonQuery();

            connect.Close();

        }

        public DataTable GetPrimerReporte(int edadMin, int edadMax)
        {
            string sQuery = "SELECT e.Nombre AS Especie, MIN(a.Peso) AS PesoMinimo, " +
               "MAX(a.Peso) AS PesoMaximo, CAST(AVG(a.Peso) AS DECIMAL(10,2)) AS PesoPromedio " +
               "FROM Animales a JOIN Especies e ON a.EspecieID = e.EspecieID " +
               $"WHERE a.Edad BETWEEN {edadMin} AND {edadMax} " +
               "GROUP BY e.Nombre;";
            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();
            
            cmd.CommandText = sQuery;

            SqlDataAdapter adapter = new SqlDataAdapter((SqlCommand)cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }
  
        public DataTable GetSegundoReporte()
        {
            string sQuery = "SELECT c.Nombre AS Cliente, COUNT(a.AnimalID) AS CantidadAnimales " +
                "FROM Animales a JOIN Clientes c ON a.ClienteDNI = c.DNI " +
                "GROUP BY c.Nombre ORDER BY CantidadAnimales ASC;";

            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = sQuery;

            SqlDataAdapter adapter = new SqlDataAdapter((SqlCommand)cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
