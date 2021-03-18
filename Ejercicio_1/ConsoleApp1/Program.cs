using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace ConsoleApp1
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            string encabezadoMaximo = "MAXIMO";
            string encabezadoMninimo = "MINIMO";
            string encabezadoPromedio = "PROMEDIO";
            int numero = 0;
            string cadena = "";
            int min = 0;
            int max = 0;
            int acum = 0;
            float promedio = 0;

            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero");
                cadena = Console.ReadLine();

                while (!(int.TryParse(cadena, out numero)))
                {
                    Console.WriteLine("Reingrese un numero");
                    cadena = Console.ReadLine();
                }

                if (i==0)
                {
                    max = numero;
                    min = numero;
                }

                if (numero > max)
                {
                    max = numero;
                }

                if (numero < min)
                {
                    min = numero;
                }
                acum = acum + numero;
            }
            promedio = acum / 5;
            Console.WriteLine("\n\nEl minimo es {0}\n",min);
            Console.WriteLine("El MAXIMO es {0}\n", max);
            Console.WriteLine("El Promedio es {0,0:#,###.00}\n", promedio);


            Console.WriteLine("\n\n{0,-30} {1,-30} {2,-30}\n\n",encabezadoMninimo,encabezadoMaximo,encabezadoPromedio);
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("{0,-30} {1,-30} {2,-30:#,###.00}", min, max, promedio);
            }




            Console.WriteLine("\n\n{0,-25}\t {1,-25}\t {2,-25}\n\n", encabezadoMninimo, encabezadoMaximo, encabezadoPromedio);
            Console.WriteLine("\n\n{0,-25}\t {1,-25}\t {2,-25:#,###.00}\n", min, max, promedio);

            Console.WriteLine( string.Format("\n\n{0,-20} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20}\n\n", encabezadoMninimo, encabezadoMaximo, encabezadoPromedio,encabezadoMninimo, encabezadoMaximo, encabezadoPromedio));
            Console.WriteLine ( string.Format("\n\n{0,-20} {1,-20} {2,-20:#,###.00} {3,-20} {4,-20} {5,-20:#,###.00}\n", min, max, promedio, min, max, promedio));
           

            Console.ReadKey();
        }
    }
}
