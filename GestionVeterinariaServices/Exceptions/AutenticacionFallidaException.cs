using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVeterinariaServices.Exceptions
{
    public class AutenticacionFallidaException : Exception
    {   
        public string Text {  get; set; }
        public AutenticacionFallidaException( string id)
        {
            this.Text = id;
        }
    }
}
