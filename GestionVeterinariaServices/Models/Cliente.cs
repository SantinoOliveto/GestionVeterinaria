using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Cliente
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Cliente(int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }
    }
}
