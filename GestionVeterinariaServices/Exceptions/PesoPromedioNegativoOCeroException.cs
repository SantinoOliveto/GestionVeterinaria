using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Exceptions
{
    public class PesoPromedioNegativoOCeroException : Exception
    {
        public string Peso { get; set; }

        public PesoPromedioNegativoOCeroException(string peso)
        {
            Peso = peso;
        }
    }
}
