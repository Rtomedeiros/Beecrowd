using System;

namespace Exerc_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Salário com Bônus
            Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
            Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, 
            informar o total a receber no final do mês, com duas casas decimais.
            */

            string NV; //NV = Nome do vendedor.
            double SF, TV, TR; //SF = Salário fixo, TV = Total de vendas no mês (em dinheiro), TR = Total a receber.

            NV = Console.ReadLine();
            SF = double.Parse(Console.ReadLine());
            TV = double.Parse(Console.ReadLine());

            TR = (TV * 0.15) + SF;

            Console.WriteLine("TOTAL = R$ "+ "{0:f2}", TR);

            Console.ReadKey();
        }
    }
}
