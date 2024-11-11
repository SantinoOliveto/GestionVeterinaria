using GestionVeterinariaServices.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.DAOs
{
    public class EspeciesDAO : ConexionDAO
    {
        public void InsertEspecie(Especie especie)
        {
            string sQuery = $"INSERT INTO Especie" +
                $"(nombres, edadesMadurez, pesosPromedio)" +
                $"VALUES (@Nombres, @EdadesMadurez, @PesosPromedio)";

            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.Parameters.AddWithValue("@Nombres", especie.Nombre);
            cmd.Parameters.AddWithValue("@EdadesMadurez", especie.Edad);
            cmd.Parameters.AddWithValue("@PesosPromedio", especie.Peso);

            cmd.CommandText = sQuery;

            cmd.ExecuteNonQuery();

            connect.Close();

            //string sQuery = $"INSERT INTO Especie" +
            //$"(nombres, edadesMadurez, pesosPromedio)" +
            //$"VALUES ({especie.Nombre}, {especie.Edad}, {especie.Peso})";
        }

        public List<Especie> GetAllEspecies()
        {
            List<Especie> listaEspecies = new List<Especie>();

            var connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "SELECT Nombres, EdadesMadurez, PesosPromedio" +
                " FROM Especie";

            SqlDataReader lector = cmd.ExecuteReader();

            while(lector.Read())
            {
                Especie especie = new Especie();

                especie.Nombre = lector.GetString(0);
                especie.Edad = lector.GetInt32(1);
                especie.Peso = lector.GetDecimal(2);
                
                listaEspecies.Add(especie);
            }

            connect.Close();

            return listaEspecies;
        }
    }
}
