using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }

        public Cliente(int dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }
    }
}
