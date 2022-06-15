using CalculadoraTajabara.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{
    public class Divisao: Operacao
    {
        public Divisao()
        {
            Operador = '/';
        }
        public override double RealizarCalculo()
        {
            double resultado = Num1 / Num2;

            HistoricoLog.GravarOperacao(this.ToString());

            this.Resultado = resultado;

            return resultado;
        }

    }
}
