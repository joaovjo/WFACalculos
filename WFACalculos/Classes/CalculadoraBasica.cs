using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFACalculos.Classes
{
    class CalculadoraBasica
    {
        double _num1;
        double _num2;
        //double _resultado;

        public double Num1 { get => _num1; set => _num1 = value; }
        public double Num2 { get => _num2; set => _num2 = value; }
        //public double Resultado { get => _resultado; set => _resultado = value; }

        public string Adicao()

        {
            return (_num1 + _num2).ToString();
        }

        public string Subtracao()

        {
            return (_num1 - _num2).ToString();
        }

        public string Multiplicacao()

        {
            return (_num1 * _num2).ToString();
        }

        public string Divisao()

        {
            return (_num1 / _num2).ToString();
        }
    }
}
