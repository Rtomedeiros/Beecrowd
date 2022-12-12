using System;

namespace Exerc_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ESFERA
            Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
            A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
            Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), 
            assumem que o resultado da divisão entre dois inteiros é outro inteiro.
            */
            const double pi = 3.14159; // Declarando pi como uma constante, um valor de ponto flutuante (dupla precisão).
            double R, VOL; //R = Raio, VOL = Volume da Esfera.

            R = double.Parse(Console.ReadLine());

            VOL = (4.0 / 3.0) * pi * (R * R * R);

            Console.WriteLine("VOLUME = "+ "{0:F3}", VOL);

            Console.ReadKey();
        }
    }
}
