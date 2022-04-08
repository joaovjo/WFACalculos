using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACalculos.Classes
{
    class CalculadoraCientifica : CalculadoraBasica
    {

        string mensagem;
        double resultado;

        public string Comparar()
        {

            if (Num1 > Num2)
            {
                mensagem = (Num1 + " Maior que " + Num2);
                return mensagem;
            }

            else if (Num1 < Num2)
            {
                mensagem = (Num2 + " é maior que " + Num1);
                return mensagem;
            }
            else
            {
                mensagem = "Os números são iguais";
                return mensagem;
            }
        }

        public string ParImpar()
        {

            double a, b, NumA, NumB;
            a = Num1;
            b = Num2;

            NumA = a % 2;
            NumB = b % 2;

            if (NumA == 0 && NumB == 0)
            {
                mensagem = "Ambos os números são Par";
                return mensagem;
            }
            else if (NumA == 1 && NumB == 1)
            {
                mensagem = "Ambos os números são Impar";
                return mensagem;
            }
            else if (NumA == 0 && NumB == 1)
            {
                mensagem = a + " é Par e " + b + " é Impar";
                return mensagem;
            }
            else
            {
                mensagem = a + " é Impar e " + b + " é Par";
                return mensagem;
            }
            
        }

        public string Porcentagem()
        {
            resultado = Num1 * Num2 / 100;

            return resultado.ToString();
        }

        public string Potencia()

        {
            resultado = Math.Pow(Num1, Num2);

            return resultado.ToString();
        }
    }
}
