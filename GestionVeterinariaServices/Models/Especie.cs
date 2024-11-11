using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Especie
    {
        public string Nombre {  get; set; }
        public int Edad { get; set; }
        public decimal Peso { get; set; }

        public Especie(string nombre, int edad, decimal peso)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Peso = peso;
        }

        public Especie() { }
    }
}
