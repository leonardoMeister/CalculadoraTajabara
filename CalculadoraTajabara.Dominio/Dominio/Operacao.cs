using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio.Dominio
{
    public class Operacao
    {
        public double Num1;
        public double Num2;
        public double Resultado;
        public char Operador;

        public override string ToString()
        {
            return $"{Num1} {Operador} {Num2} = {Resultado}";
        }
    }
}
