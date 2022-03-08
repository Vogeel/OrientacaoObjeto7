using System;

namespace OrientacaoObjeto7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.salariobase = 1200;
            Console.WriteLine("Quanto de venda o vendedor fez este mes?");
            vendedor.valordevendas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem de comissao do vendedor?");
            vendedor.porcem = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Com o total de vendas de: R${vendedor.valordevendas}, o vendedor obteve um salario total com comissao de: R${vendedor.salariofinal()}");
            Console.ReadKey();


        }
    }
}
