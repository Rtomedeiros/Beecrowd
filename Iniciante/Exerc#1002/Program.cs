using System;

namespace Exerc_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A fórmula para calcular a área de uma circunferência é: area = π . raio2.
            Considerando para este problema que π = 3.14159:
            - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.
            */
            
            double area, pi, raio;

            pi = 3.14159;

            raio = double.Parse(Console.ReadLine());

            area = pi * (raio * raio);

            //Console.WriteLine("A=" + area);

            Console.WriteLine("A=" + "{0:F4}", area);

        }
    }
}
