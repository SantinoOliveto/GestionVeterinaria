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
                $"VALUES ({especie.Nombre}, {especie.Edad}, {especie.Peso})";

            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = sQuery;

            cmd.ExecuteNonQuery();

            connect.Close();
        }

        public List<Especie> GetAllEspecies()
        {
            List<Especie> listaEspecies = new List<Especie>();

            var connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "SELECT nombres, edadesMadurez, pesosPromedio" +
                "* FROM Especies";

            SqlDataReader lector = cmd.ExecuteReader();

            while(lector.Read())
            {
                Especie especie = new Especie()
                {
                    Nombre = lector.GetString(0),
                    Edad = lector.GetInt32(1),
                    Peso = lector.GetInt32(2)
                };
                
                listaEspecies.Add(especie);
            }
            connect.Close();

            return listaEspecies;
        }
    }
}
