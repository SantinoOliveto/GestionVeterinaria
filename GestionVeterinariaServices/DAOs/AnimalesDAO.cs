using GestionVeterinariaServices.Models;
using System;
using System.Collections.Generic;
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

            cmd.CommandText = "SELECT Nombre, Peso, Edad, ClienteDNI, EspecieID" +
                " FROM Animales";

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Animal animal = new Animal()
                {

                    Nombre = lector.GetString(1),
                    Peso = lector.GetDecimal(2),
                    Edad = lector.GetInt32(3),
                    ClienteDNI = lector.GetInt32(4),
                    EspecieID = lector.GetInt32(5),

                   
                };

                Console.WriteLine($"{animal.Nombre}, {animal.Peso}, {animal.Edad}, {animal.ClienteDNI}, {animal.EspecieID}");
                listaAnimales.Add(animal);
            }
            Console.ReadKey();
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

            //string sQuery = $"INSERT INTO Especie" +
            //$"(nombres, edadesMadurez, pesosPromedio)" +
            //$"VALUES ({especie.Nombre}, {especie.Edad}, {especie.Peso})";
        }
    }
}
