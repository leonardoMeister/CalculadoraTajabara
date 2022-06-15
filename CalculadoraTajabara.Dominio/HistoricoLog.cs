using CalculadoraTajabara.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{
    public class HistoricoLog
    {
        public List<Operacao> operacoes;
        public HistoricoLog()
        {
            operacoes = new();
        }

        public void GravarOperacao(Operacao operacao)
        {
            operacoes.Add(operacao);
        }
    }
}
