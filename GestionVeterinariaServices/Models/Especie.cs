using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Especie
    {
        public string nombre {  get; set; }
        public int edad { get; set; }
        public int peso { get; set; }

        public Especie()
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
        }
    }
}
