using CalculadoraTajabara.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{
    public class Subtracao : Operacao
    {
        public Subtracao()
        {
            Operador = '-';
        }
        public override string RealizarCalculo()
        {
            this.Resultado = Num1 - Num2;

            return this.ToString();
        }

    }
}
