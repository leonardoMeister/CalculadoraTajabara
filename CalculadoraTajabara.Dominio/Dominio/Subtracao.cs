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
        public Subtracao(char operacao, double resultado, double primeiroValor, double segundoValor)
        {
            this.Operador = operacao;
            this.Resultado = resultado;
            this.Num1 = primeiroValor;
            this.Num2 = segundoValor;
        }

        public double SubstracaoNumeros(double primeiroValor, double segundoValor)
        {
            double resultado = primeiroValor - segundoValor;

            HistoricoLog.GravarOperacao(this.ToString());

            return resultado;
        }

    }
}
