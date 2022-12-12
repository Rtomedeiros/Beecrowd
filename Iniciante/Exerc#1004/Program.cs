using System;

namespace Exerc_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Produto Simples
            Leia dois valores inteiros.
            A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
            A seguir mostre a variável PROD com mensagem correspondente. 
            */

            int PROD, A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            PROD = A * B;

            Console.WriteLine("PROD = "+ PROD);

            Console.ReadKey();
        }
    }
}
