using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Validacion
    {
        public static int ValidarEntero(string cadena)
        {
            int retorno = 0;

            while (!(int.TryParse(cadena, out retorno)))
            {
                Console.WriteLine("ERROR,..Reingrese un numero");
                cadena = Console.ReadLine();
            }
            return retorno; 
        }
    }
}
