using CalculadoraTajabara.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTajabara.Dominio
{
    public class Soma : Operacao
    {

        public void RealizarSoma()
        {
            Resultado = Num1 + Num2;
        }
    }
}
