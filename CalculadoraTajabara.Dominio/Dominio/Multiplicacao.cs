using CalculadoraTajabara.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{
    public class Multiplicacao : Operacao
    {
        public Multiplicacao(string operacao, double resultado, double primeiroValor, double segundoValor)
        {
            this.operacao = operacao;
            this.resultado = resultado;
            this.primeiroValor = primeiroValor;
            this.segundoValor = segundoValor;
        }

        public static double MultiplicacaoNumeros(double primeiroValor, double segundoValor)
        {
            string operacao = "Multiplicacao";
            double resultado = primeiroValor * segundoValor;

            HitoricoLog.Gravar(operacao, primeiroValor, segundoValor, resultado);

            return resultado;
        }

    }
}
