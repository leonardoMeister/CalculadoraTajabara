using CalculadoraTajabara.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{
    public class Soma : Operacao
    {
        public Soma()
        {
            Operador = '+';
        }
        public override string RealizarCalculo()
        {
            Resultado = Num1 + Num2;

            return this.ToString();
        }
    }
}