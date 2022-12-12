using System;

namespace Exerc_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Salário
            Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
            o valor que recebe por hora e calcula o salário desse funcionário.
            A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
            */
            
            int NF, NHT; //NF = Número funcionario, NHT = Número de horas trabalhadas.
            float VPH, SF; //VPH = valor referente a hora trabalhada, SF = Salário do Funcionário.

            NF = int.Parse(Console.ReadLine());
            NHT = int.Parse(Console.ReadLine());
            VPH = float.Parse(Console.ReadLine());

            SF = NHT * VPH;

            Console.WriteLine("NUMBER = "+ NF);
            Console.WriteLine("SALARY = U$ "+ "{0:F2}", SF);

            Console.ReadKey();
        }
    }
}
