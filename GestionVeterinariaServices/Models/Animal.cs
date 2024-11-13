using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Animal
    {
        public int ClienteDNI {  get; set; }
        public int EspecieID { get; set; }
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public int Edad {  get; set; }

        public Animal(int cliente, int especie, string nombre, int peso, int edad)
        {
            ClienteDNI = cliente;
            EspecieID = especie;
            Nombre = nombre;
            Peso = peso;
            Edad = edad;
        }

        public Animal() { } 
    }
}
