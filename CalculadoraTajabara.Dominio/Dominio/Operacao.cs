using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio.Dominio
{
    public class Operacao
    {
        public double Num1;
        public double Num2;
        public double Resultado;
        public char Operador;

        public override string ToString()
        {
            return $"{Num1} {Operador} {Num2} = {Resultado}";
        }

        public virtual double RealizarCalculo()
        {
            return 0;
        }

        public void PegarDados()
        {
            Console.WriteLine("Informe o numero 1");
            Num1 =  Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Informe o numero 2");
            Num2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
