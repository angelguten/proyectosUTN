using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// El método ValidarOperador será privado y estático. 
        /// Deberá validar que el operador recibido sea valido
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> +, -, / , *</returns>Caso contrario retornará +. 
        private static string ValidarOperador(char operador)
        {
                if (operador != '+' && operador != '-' && operador != '*' && operador != '/')// || operador == '\0')
                {
                    operador = '+';
                }

          
           
            return operador.ToString();
        }

        /// <summary>
        /// El método Operar será de clase: validará y realizará la operación pedidas entre ambos números.   
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {

            char operadorChar = ' ';
            char.TryParse(operador, out operadorChar);
           
            double resultado = 0;

            switch (Calculadora.ValidarOperador(operadorChar))
            {
                case "+":
                    resultado = num1 + num2;
                break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
        
}
