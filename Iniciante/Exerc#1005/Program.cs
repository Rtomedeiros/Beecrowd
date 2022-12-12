using System;

namespace Exerc_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Media 1
            Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. 
            A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 
            (A soma dos pesos portanto é 11). 
            Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
            */

            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            A = A * 3.5;
            B = B * 7.5;

            MEDIA = (A + B) / 11;

            Console.WriteLine("MEDIA = "+ "{0:F5}", MEDIA);


        }
    }
}
