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
            string sQuery = "INSERT INTO Especies (Nombre, EdadMadurez, PesoPromedio) VALUES (@Nombres, @EdadesMadurez, @PesosPromedio)";

            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.Parameters.AddWithValue("@Nombres", especie.Nombre);
            cmd.Parameters.AddWithValue("@EdadesMadurez", especie.EdadMadurez);
            cmd.Parameters.AddWithValue("@PesosPromedio", especie.PesoPromedio);

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

            cmd.CommandText = "SELECT Nombre, EdadMadurez, PesoPromedio" +
                " FROM Especies";

            SqlDataReader lector = cmd.ExecuteReader();

            while(lector.Read())
            {
                Especie especie = new Especie();

                especie.Nombre = lector.GetString(0);
                especie.EdadMadurez = lector.GetInt32(1);
                especie.PesoPromedio = lector.GetDecimal(2);
                
                listaEspecies.Add(especie);
            }

            connect.Close();

            return listaEspecies;
        }
    }
}
