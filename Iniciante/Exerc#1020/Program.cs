using System;

namespace Exerc_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IDADE EM DIAS
            Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias
            Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. 
            Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 
            Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
            Entrada: O arquivo de entrada contém um valor inteiro.
            Saída: Imprima a saída conforme exemplo fornecido.
            */
            int VALOR, ANO = 0, MES = 0;

            VALOR = int.Parse(Console.ReadLine());

            while(VALOR >= 30)
            {
                if(VALOR >= 365)
                {
                    VALOR = VALOR - 365;
                    ANO = ANO + 1;
                }
                else if(VALOR >= 30)
                {
                    VALOR = VALOR - 30;
                    MES = MES + 1;
                }
            }

            Console.WriteLine(ANO + " ano(s)");
            Console.WriteLine(MES + " mes(es)");
            Console.WriteLine(VALOR + " dia(s)");

            Console.ReadKey();
        }
    }
}
