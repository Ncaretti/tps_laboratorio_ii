using System;

namespace Entidades
{
    public class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if(!(operador == '+' || operador == '-' || operador == '*' || operador == '/'))
            {
                operador = '+';
            }

            return operador;
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;
            char operadorValidado = ValidarOperador(operador);

            switch (operadorValidado)
            {
                case '+':
                    resultado = num1 + num2;
                break;

                case '-':
                    resultado = num1 - num2;
                break;

                case '/':
                    resultado = num1 / num2;
                break;

                case '*':
                    resultado = num1 * num2;
                break;

                default:
                    resultado = num1 + num2;
                break;
            }
            return resultado;
        }
    } 
}
