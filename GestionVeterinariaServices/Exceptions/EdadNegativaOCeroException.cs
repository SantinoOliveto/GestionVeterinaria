using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Exceptions
{
    public class EdadNegativaOCeroException : Exception
    {
        public string Edad {  get; set; }

        public EdadNegativaOCeroException(string edad)
        {
            Edad = edad;
        }
    }
}
