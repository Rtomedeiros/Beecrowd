using System;

namespace Exerc_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ÁREA
            Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B. 
            */

            const double pi = 3.14159;
            double A, B, C, TRI, CIR, TRA, QUA, RET;

            string[] valor = Console.ReadLine().Split(' ');   //Digitar a string com os valores de entrada, e dividi-los.

            A = double.Parse(valor[0]);     //Atribuindo o 1º valor a A.
            B = double.Parse(valor[1]);     //Atribuindo o 2º valor a B.
            C = double.Parse(valor[2]);     //Atribuindo o 3º valor a C.

            TRI = (A * C) / 2.0;        //Cálculo da área do Triângulo Retângulo.
            CIR = pi * (C * C);         //Cálculo da área do Círculo.
            TRA = ((A + B) * C) / 2.0;  //Cálculo da área do Trapézio.
            QUA = B * B;                //Cálculo da área do Quadrado.
            RET = A * B;                //Cálculo da área do Retângulo.

            Console.WriteLine("TRIANGULO: "+ "{0:F3}", TRI);
            Console.WriteLine("CIRCULO: "+ "{0:F3}", CIR);
            Console.WriteLine("TRAPEZIO: "+ "{0:F3}", TRA);
            Console.WriteLine("QUADRADO: "+ "{0:F3}", QUA);
            Console.WriteLine("RETANGULO: "+ "{0:F3}", RET);

            Console.ReadKey();
        }
    }
}
