using System;

namespace Exerc_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CONVERSÃO DE TEMPO
            Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, 
            e informe-o expresso no formato horas:minutos:segundos.
            Entrada: O arquivo de entrada contém um valor inteiro N.
            Saída: Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
            */
            int N, H = 0, M = 0;

            N = int.Parse(Console.ReadLine());

            //While rodará enquanto o N for maior que 60, O N irá diminuir de acordo com o if interno para subtrair os segundos das horas e dos minutos,
            //quando sobrar um valor de N menor ou igual que 60, ou seja, quando estiver subtraido os segundos suficientes das horas e minutos, o While acaba.
            while(N >= 60)
            {
                if(N >= 3600)   //1H = 3600s
                {
                    N = N - 3600;
                    H = H + 1;
                }
                else if(N >= 60)    //1M = 60s
                {
                    N = N - 60;
                    M = M + 1;
                }
            }

            Console.WriteLine(H + ":" + M + ":" + N);

            Console.ReadKey();
        }
    }
}
