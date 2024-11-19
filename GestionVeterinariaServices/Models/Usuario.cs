using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Usuario
    {
        public string Nombre {  get; set; }
        public string Clave {  get; set; }

        public Usuario(string nombre, string clave)
        {
            Nombre = nombre;
            Clave = clave;
        }

        public Usuario()
        {
        }
    }
}
