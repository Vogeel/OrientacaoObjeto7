using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto7.ConsoleApp
{
    internal class Vendedor
    {
        public double salariobase;
        public double valordevendas;
        public double porcem;
        public double porcentagem()
        {
            double calculoporcentagem = porcem / 100;
            return calculoporcentagem;
        }

        public double comissao()
        {
            double ValorComissao = valordevendas * porcentagem();
            return ValorComissao;
        }
        public double salariofinal()
        {
            double ValorFinal = comissao() + salariobase;
            return ValorFinal;
        }
    }
}
