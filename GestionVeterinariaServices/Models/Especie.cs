﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public int EdadMadurez { get; set; }
        public decimal PesoPromedio { get; set; }

        public Especie(string nombre, int edad, decimal peso)
        {
            this.Nombre = nombre;
            this.EdadMadurez = edad;
            this.PesoPromedio = peso;
        }

        public Especie() { }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
