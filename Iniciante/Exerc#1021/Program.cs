using System;

namespace Exerc_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            NOTAS E MOEDAS
            Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário.
            A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.
            As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01.
            A seguir mostre a relação de notas necessárias.
            Entrada: O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).
            Saída: Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.
            Obs: Utilize ponto (.) para separar a parte decimal.  
            */
            double Ninicial;
            int N, CONT100 = 0, CONT50 = 0, CONT20 = 0, CONT10 = 0, CONT5 = 0, CONT2 = 0;
            int CONTM100 = 0, CONTM50 = 0, CONTM25 = 0, CONTM10 = 0, CONTM5 = 0, CONTM1 = 0;

            //Do While para rodar enquanto o N inicial não estiver dentro do intervalo correto.
            do
            {
                Ninicial = double.Parse(Console.ReadLine());  //Entrada de N inicial.
                
                if((Ninicial <= 0.0) || (Ninicial > 1000000.0))   //Se o N inicial está fora do intervalo mostra mensagem de erro.
                {
                    Console.WriteLine("N inválido!");
                }
            }while((Ninicial <= 0.0) || (Ninicial > 1000000.0));

            // Multiplicando o valor de N inicial por 100, para fazer a conversão do N para um número inteiro 
            //e não perder os valores dos centavos,
            //Assim mantendo a nova proporção de x100 no if posterior que faz a contagem de cada nota e moeda.
            Ninicial = Ninicial * 100.0;
            N = (int)Ninicial;              //conversão de double para int.

            //While para rodar enquanto o N é maior que 0.
            while(N > 0)
            {
                //Este if faz a verificação do valor de N em cada tipo de nota, se o N for maior ou igual a nota, 
                //há a dedução do valor da nota ou moeda, e conta uma unidade da mesma.
                //A proporção foi aumentada em x100 para verificar os valores dos centavos, usando apenas números inteiros.
                if(N >= 10000)      //Análise nota 100.
                {
                    N = N - 10000;
                    CONT100 = CONT100 + 1;
                }
                else if(N >= 5000)      //Análise nota 50.
                {
                    N = N - 5000;
                    CONT50 = CONT50 + 1;
                }
                else if(N >= 2000)      //Análise nota 20.
                {
                    N = N - 2000;
                    CONT20 = CONT20 + 1;
                }
                else if(N >= 1000)      //Análise nota 10.
                {
                    N = N - 1000;
                    CONT10 = CONT10 + 1;
                }
                else if(N >= 500)      //Análise nota 5.
                {
                    N = N - 500;
                    CONT5 = CONT5 + 1;
                }
                else if(N >= 200)      //Análise nota 2.
                {
                    N = N - 200;
                    CONT2 = CONT2 + 1;
                }
                else if(N >= 100)      //Análise moeda 1.
                {
                    N = N - 100;
                    CONTM100 = CONTM100 + 1;
                }
                else if(N >= 50)      //Análise moeda 0,50.
                {
                    N = N - 50;
                    CONTM50 = CONTM50 + 1;
                }
                else if(N >= 25)      //Análise moeda 0,25.
                {
                    N = N - 25;
                    CONTM25 = CONTM25 + 1;
                }
                else if(N >= 10)      //Análise moeda 0,10.
                {
                    N = N - 10;
                    CONTM10 = CONTM10 + 1;
                }
                else if(N >= 5)      //Análise moeda 0,05.
                {
                    N = N - 5;
                    CONTM5 = CONTM5 + 1;
                }
                else if(N >= 1)      //Análise moeda 0,01.
                {
                    N = N - 1;
                    CONTM1 = CONTM1 + 1;
                }
            }
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine(CONT100 + " nota(s) de R$ 100.00");
            Console.WriteLine(CONT50 + " nota(s) de R$ 50.00");
            Console.WriteLine(CONT20 + " nota(s) de R$ 20.00");
            Console.WriteLine(CONT10 + " nota(s) de R$ 10.00");
            Console.WriteLine(CONT5 + " nota(s) de R$ 5.00");
            Console.WriteLine(CONT2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(CONTM100 + " moeda(s) de R$ 1.00");
            Console.WriteLine(CONTM50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(CONTM25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(CONTM10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(CONTM5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(CONTM1 + " moeda(s) de R$ 0.01");

            Console.ReadKey();
        }
    }
}
