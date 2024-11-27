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

            
        }

        public List<Especie> GetAllEspecies()
        {
            List<Especie> listaEspecies = new List<Especie>();

            var connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "SELECT EspecieID, Nombre, EdadMadurez, PesoPromedio" +
                " FROM Especies";

            SqlDataReader lector = cmd.ExecuteReader();

            while(lector.Read())
            {
                Especie especie = new Especie();
                especie.Id = lector.GetInt32(0);
                especie.Nombre = lector.GetString(1);
                especie.EdadMadurez = lector.GetInt32(2);
                especie.PesoPromedio = lector.GetDecimal(3);
                
                listaEspecies.Add(especie);
            }

            connect.Close();

            return listaEspecies;
        }
    }
}
