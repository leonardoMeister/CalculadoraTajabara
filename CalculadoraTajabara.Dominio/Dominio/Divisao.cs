using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{
    public static class Divisao
    {
        public static double DivisaoNumeros(double primeiroValor, double segundoValor)
        {
            string operacao = "Divisão";
            double resultado = primeiroValor / segundoValor;

            HitoricoLog.Gravar(operacao, primeiroValor,segundoValor,resultado);

            return resultado;   
        }

    }
}
