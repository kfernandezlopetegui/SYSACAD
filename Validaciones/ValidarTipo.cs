using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validaciones
{
    public class ValidarTipo
    {
        public ValidarTipo() { }

        public static bool ValidarEsDigito(string numero)
        {
            if (!Regex.IsMatch(numero, @"^\d+$"))
            {
                
                return true;
            }
            return false;
        }

       
    }
}
