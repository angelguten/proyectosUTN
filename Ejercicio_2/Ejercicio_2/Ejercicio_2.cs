using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            double numero = 0;
            string cadena = " ";
            double cuadrado = 0;
            double cubo = 0;

            Console.WriteLine("\nIngrese un NUMERO POSITIVO\n");
            cadena = Console.ReadLine();

            while (!(double.TryParse(cadena, out numero)))
            {
                Console.WriteLine("\nERROR.Reingresar numero\n");
                cadena = Console.ReadLine();
            }

            if (numero > 0)
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
            }
            else
                {
                    while(numero<0||numero==0)
                    {
                        Console.WriteLine("\nERROR.Reingresar numero\n");
                        cadena = Console.ReadLine();
                        while (!(double.TryParse(cadena, out numero)))
                        {
                            Console.WriteLine("\nERROR.Reingresar numero\n");
                            cadena = Console.ReadLine();
                        }
                    }
                    cuadrado = Math.Pow(numero, 2);
                    cubo = Math.Pow(numero, 3);
                }
            Console.WriteLine("El cuadrado de {0} es {1}",numero,cuadrado);
            Console.WriteLine("El cubo de {0} es {1}", numero, cubo);

            Console.ReadKey();
        }
    }
}
