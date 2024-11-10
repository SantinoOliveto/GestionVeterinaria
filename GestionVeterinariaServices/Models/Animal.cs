using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Animal
    {
        public Cliente cliente {  get; set; }
        public Especie especie { get; set; }
        public string nombre { get; set; }
        public int peso { get; set; }
        public int edad {  get; set; }
    }
}
