using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Exceptions
{
    public class EdadMadurezNegativaOCeroException : Exception
    {
        public string Edad { get; set; }

        public EdadMadurezNegativaOCeroException(string edad)
        {
            Edad = edad;
        }
    }
}
