using CalculadoraTajabara.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{

    public  class Multiplicacao: Operacao
    {
        public static double MultiplicacaoNumeros(double primeiroValor, double segundoValor)
        {
            string operacao = "Multiplicacao";
            double resultado = primeiroValor / segundoValor;

            HitoricoLog.Gravar(operacao, primeiroValor, segundoValor, resultado);

            return resultado;
        }

    }
}
