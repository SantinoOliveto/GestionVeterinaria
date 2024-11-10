using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Cliente
    {
        public int dni { get; set; }
        public string nombre { get; set; }

        public Cliente(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
    }
}
