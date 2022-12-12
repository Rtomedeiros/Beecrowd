using System;

namespace Exerc_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CÉDULAS
            Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto.
            As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
            Entrada: O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
            Saída: Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, 
            conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, 
            caso contrário seu programa apresentará a mensagem: “Presentation Error”.
            */
            int N, Ninicial, CONT100 = 0, CONT50 = 0, CONT20 = 0, CONT10 = 0, CONT5 = 0, CONT2 = 0, CONT1 = 0;

            //Do While para rodar enquanto o N não estiver dentro do intervalo correto.
            do
            {
                N = int.Parse(Console.ReadLine());  //Entrada de N.
                if((N <= 0) || (N > 1000000))   //Se o N está fora do intervalo mostra mensagem de erro.
                {
                    Console.WriteLine("N inválido!");
                }
            }while((N <= 0) || (N > 1000000));

            Ninicial = N;   //Atribuindo o valor inicial de N para uma outra variável.

            //While para rodar enquanto o N é maior que 0.
            while(N > 0)
            {
                //Este if faz a verificação do valor de N em cada tipo de nota, se o N for maior ou igual a nota, 
                //há a dedução do valor da nota e conta um unidade da mesma.
                if(N >= 100)
                {
                    N = N - 100;
                    CONT100 = CONT100 + 1;
                }
                else if(N >= 50)
                {
                    N = N - 50;
                    CONT50 = CONT50 + 1;
                }
                else if(N >= 20)
                {
                    N = N - 20;
                    CONT20 = CONT20 + 1;
                }
                else if(N >= 10)
                {
                    N = N - 10;
                    CONT10 = CONT10 + 1;
                }
                else if(N >= 5)
                {
                    N = N - 5;
                    CONT5 = CONT5 + 1;
                }
                else if(N >= 2)
                {
                    N = N - 2;
                    CONT2 = CONT2 + 1;
                }
                else if(N >= 1)
                {
                    N = N - 1;
                    CONT1 = CONT1 + 1;
                }
            }
            
            Console.WriteLine(Ninicial);
            Console.WriteLine(CONT100 + " nota(s) de R$ 100,00");
            Console.WriteLine(CONT50 + " nota(s) de R$ 50,00");
            Console.WriteLine(CONT20 + " nota(s) de R$ 20,00");
            Console.WriteLine(CONT10 + " nota(s) de R$ 10,00");
            Console.WriteLine(CONT5 + " nota(s) de R$ 5,00");
            Console.WriteLine(CONT2 + " nota(s) de R$ 2,00");
            Console.WriteLine(CONT1 + " nota(s) de R$ 1,00");

            Console.ReadKey();
        }
    }
}
