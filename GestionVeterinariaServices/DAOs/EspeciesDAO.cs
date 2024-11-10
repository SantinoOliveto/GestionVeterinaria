using GestionVeterinariaServices.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.DAOs
{
    public class EspeciesDAO
    {
        private readonly string sConexion = "";

        private SqlConnection GetConexion()
        {
            SqlConnection connect = new SqlConnection(this.sConexion);
            connect.Open();
            return connect;
        }

        public void Insert(Especie especie)
        {
            string sQuery = $"INSERT INTO Especie" +
                $"(nombres, edadesMadurez, pesosPromedio)" +
                $"VALUES ({especie.nombre}, {especie.edad}, {especie.peso})";

            SqlConnection connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = sQuery;

            cmd.ExecuteNonQuery();

            connect.Close();
        }

        public List<Especie> GetAll()
        {
            List<Especie> listaEspecies = new List<Especie>();

            var connect = this.GetConexion();

            SqlCommand cmd = connect.CreateCommand();

            cmd.CommandText = "SELECT nombres, edadesMadurez, pesosPromedio" +
                "* FROM Especies";

            SqlDataReader lector = cmd.ExecuteReader();

            while(lector.Read())
            {
                Especie especie = new Especie();

                especie.nombre = lector.GetString(0);
                especie.edad = lector.GetInt32(1);
                especie.peso = lector.GetInt32(2);
                
                listaEspecies.Add(especie);
            }

            //Falta algo
            connect.Close();

            return listaEspecies;

            //Test
        }
    }
}
