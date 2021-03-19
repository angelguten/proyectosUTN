using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region ATRIBUTOS
        private double numero;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// La propiedad SetNumero asignará un valor al atributo número, previa validación. 
        /// En este lugar será el único en todo el código que llame al método ValidarNumero
        /// </summary>
        public string setNumero
        {
            set
                {
                    this.numero = ValidarNumero(value);
                }
        }
        #endregion

        #region CONSTRUCTORES
        //El constructor por defecto (sin parámetros) asignará valor 0 al atributo numero. 
        //ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en formato double.
        //Caso contrario, retornará 0. 

        public Numero():this(0)
        {
           
        }
        public Numero(double numero):this(numero.ToString())
        {
        
        }
        public Numero(string strNumero)
        {
            setNumero = strNumero;
        }
        #endregion

        #region METODOS
        //El método privado EsBinario validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'. 

        private bool EsBinario(string binario)
        {
            bool retorno = true;

            for (int i= 0;i<binario.Length;i++)
            { 
                if(binario[i]!='1' && binario[i]!='0')
                {
                    retorno = false;         
                }
            }
            return retorno;
        }

        //Los métodos BinarioDecimal y DecimalBinario convertirán el Resultado, trabajarán con enteros positivos, 
        //quedándose para esto con el valor absoluto y entero del double recibido:
        //  
        //  El método BinarioDecimal validará que se trate de un binario y luego convertirá ese número binario a decimal, en caso de ser posible. 
        //  Caso contrario retornará "Valor inválido".
        //
        public string BinarioDecimal(string binario)
        {
            string retorno ="";
            if (this.EsBinario(binario))
            {

                int acum = 0;
                int n = binario.Length - 1;
                for (int i = 0; i <= n; i++)
                {
                    if (binario[i]=='1')
                    { 
                        acum = acum + 1*(2 ^(n - i));//acum = acum + (int)(binario[i]) * (2 ^ (n - i));
                    }     
                }
                retorno = acum.ToString();


            }
            else
            {
                retorno = "/nValor invalido/n";
            }
            return retorno;
        }




        //  Ambas opciones del método DecimalBinario convertirán un número decimal a binario, en caso de ser posible.
        //  Caso contrario retornará "Valor inválido". Reutilizar código. 


        public string DecimalBinario(string numero)
        {

            return numero;
        }

        public string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";




            return retorno;
        }

        /// <summary>
        /// ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en formato double. 
        /// Caso contrario, retornará 0. 
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double numeroValidado=0;
            if (double.TryParse(strNumero, out numeroValidado))
            {
                return numeroValidado;
            }

         return numeroValidado;
        }

        #endregion

        #region SOBRECARGA DE OPERADORES
        // Los operadores realizarán las operaciones correspondientes entre dos números.
        // Si se tratara de una división por 0, retornará double.MinValue. 

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado = double.MinValue; ;
            if (n2.numero != 0)
            { 
                resultado= n1.numero / n2.numero;
            }
            return resultado;
        }
        #endregion

        #region
        #endregion
    }
}
