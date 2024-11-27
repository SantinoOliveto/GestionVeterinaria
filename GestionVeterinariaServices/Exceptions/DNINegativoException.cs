using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Exceptions
{
    public class DNINegativoException : Exception
    {
       public string DNI {  get; set; }

        public DNINegativoException(string dNI)
        {
            DNI = dNI;
        }
    }
}
