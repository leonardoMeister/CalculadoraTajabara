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
                        ope.PegarDados();
                        ope.RealizarCalculo();
                        break;
                    case "2":
                        ope = new Subtracao();
                        ope.PegarDados();
                        ope.RealizarCalculo();
                        break;
                    case "3":
                        ope = new Divisao();
                        ope.PegarDados();
                        ope.RealizarCalculo();
                        break;
                    case "4":
                        ope = new Multiplicacao();
                        ope.PegarDados();
                        ope.RealizarCalculo();
                        break;
                }
            }
        }

        private bool ValidarOpcao(string opcao)
        {
            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4") return false;

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
