    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            int resto = 0;
            int acum = 0;
            int n = 0;
            int cont = 0;

            for(int j=2;j<j+1;j++)
            {
                for (int k =1;k<j;k++)
                {
                    resto = j % k;

                    if(resto==0)
                    {
                        acum = acum + k;
                        n = j;
                    }
                }
                if (acum==n)
                {
                    Console.WriteLine("{0} es numero perfecto",n);
                    Console.ReadKey();
                    j = n + 1;
                    cont = cont + 1;
                }

                acum = 0;

                if (cont==4)
                {
                    break;
                }

            }
        }
    }
}
