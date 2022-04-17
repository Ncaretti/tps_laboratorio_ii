using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Propiedad encargada de asignar un valor validado al atributo numero
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Constructor por defecto que asigna 0 al atributo numero
        /// </summary>
        public Operando() : this(0)
        {
        }

        /// <summary>
        /// Constructor que asgina el valor recibido por parametro al atributo numero
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que asgina el string recibido por parametro a la propiedad Numero
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Metodo encargado de validar el operador recibido por parametro
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double numero;

            if(!(double.TryParse(strNumero, out numero)))
            {
                numero = 0;
            }

            return numero;
        }

        /// <summary>
        /// Metodo encargado de definir si el parametro es binario o no
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            bool esBinario = true;

            foreach (char c  in binario)
            {
                if(c != '0' && c!= '1')
                {
                    esBinario = false;
                    break;
                }
            }

            return esBinario;
        }

        /// <summary>
        /// Metodo encargado de convertir el parametro recibido en un numero decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            string result = "Valor inválido";
            int num;

           if (EsBinario(binario))
           {
                num = Convert.ToInt32(binario, 2);
                if(num>0)
                {
                    result = num.ToString();
                }
                
           }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        /// <summary>
        /// Metodo encargado de convertir el parametro recibido en un numero binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            string resultado = "Valor inválido";

            if(double.TryParse(numero, out double num))
            {
                if(num>0)
                {
                    Math.Truncate(num);
                    resultado = Convert.ToString((int)num, 2);
                }
                if(num<0)
                {
                    double numTruncate = Math.Abs(num);
                    Math.Truncate(numTruncate);
                    resultado = Convert.ToString((int)numTruncate, 2);
                }
            }

            return resultado;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;

            if(n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }



    }
}
