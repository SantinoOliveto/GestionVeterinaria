using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Animal
    {
        public Cliente Cliente {  get; set; }
        public Especie Especie { get; set; }
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public int Edad {  get; set; }

        public Animal(Cliente cliente, Especie especie, string nombre, int peso, int edad)
        {
            Cliente = cliente;
            Especie = especie;
            Nombre = nombre;
            Peso = peso;
            Edad = edad;
        }
    }
}
