using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Ejercicio_3
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 0;

            int cont = 0;
            int resto = 0;

            string cadena = " ";
            Console.WriteLine("Ingrese un numero");
            cadena = Console.ReadLine();
            n = Validacion.ValidarEntero(cadena);

            for (int i=1;i<=n;i++)
            {
                k = i;
                for (int j=1;j<=k;j++)
                {
                    resto = i % j;
                    if (resto==0)
                    {
                        cont = cont + 1;
                    }
                    if (cont > 2)
                    {
                        break;
                    }
                }
                if (cont <= 2)
                {
                    Console.WriteLine("{0} es PRIMO",k);
                    Console.ReadKey();
                }
                cont = 0;
            }

            
        }
    }
}
