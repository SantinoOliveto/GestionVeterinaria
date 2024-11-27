using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.DAOs
{
    public class ConexionDAO
    {
        // NO OLVIDARNOS DE CAMBIAR EL STRING CONNECTION EN CADA PRUEBA, PUEDE QUE ESTES EN OTRA BASE DE DATOS
        private const string STRING_CONNECTION = "Server=MAXI\\SQLEXPRESS;Database=VeterinariaTEST;Trusted_Connection=True;";

        public SqlConnection GetConexion()
        {
            SqlConnection connect = new SqlConnection(STRING_CONNECTION);
            connect.Open();
            return connect;
        }
    }
}
