using CalculadoraTajabara.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{
    public class Menu
    {
        HistoricoLog hist = new HistoricoLog();

        public void MostrarMenu()
        {
            string opcao;

            while (true)
            {
                ConfiguracaoMenuInicial();
                opcao = PegarOpcao();

                if (DeveContinuarOuNao(opcao))
                    break;

                if (ValidarOpcao(opcao) != true)
                {
                    Console.WriteLine("OPCAO INVALIDA TENTE NOVAMENTE");
                    continue;
                }
                
                Console.Clear();

                Console.WriteLine("----------------------------------\nCalculadora Tabajara\n");

                Operacao ope;

                switch (opcao)
                {
                    case "1":
                        ope = new Soma();
                        RealizarOperacao(ope);
                        break;

                    case "2":
                        ope = new Subtracao();
                        RealizarOperacao(ope);
                        break;

                    case "3":
                        ope = new Divisao();
                        RealizarOperacao(ope);
                        break;

                    case "4":
                        ope = new Multiplicacao();
                        RealizarOperacao(ope);
                        break;

                    case "5":
                        MostrarOperacoes();
                        break;
                }

            }
        }

        private void RealizarOperacao(Operacao ope)
        {
            PegarDados(ope);
            Console.WriteLine(ope.RealizarCalculo());
            Console.ReadKey();
            hist.GravarOperacao(ope);
        }

        public void PegarDados(Operacao operacao)
        {
            Console.WriteLine("Informe o primeiro numero:");
            operacao.Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            operacao.Num2 = Convert.ToDouble(Console.ReadLine());
        }

        private void MostrarOperacoes()
        {
            foreach(var ope in hist.operacoes)
            {
                Console.WriteLine(ope.ToString());
                Console.WriteLine("----------------------------------------");
            }

            Console.ReadLine();
        }

        private bool ValidarOpcao(string opcao)
        {
            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5") return false;

            return true;
        }

        private static bool DeveContinuarOuNao(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

        private static string PegarOpcao()
        {
            string opcao;
            Console.Write("Opção: ");
            Console.WriteLine("Digite S para sair\n");
            Console.WriteLine("Digite 1 para Soma\n");
            Console.WriteLine("Digite 2 para Subtracao\n");
            Console.WriteLine("Digite 3 para Divisao\n");
            Console.WriteLine("Digite 4 para Multiplicacao\n");
            Console.WriteLine("Digite 5 para Vizualização\n");
            opcao = Console.ReadLine();
            return opcao;
        }

        private static void ConfiguracaoMenuInicial()
        {
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara\n");

            Console.WriteLine("Tela Principal\n");
        }
    }
}