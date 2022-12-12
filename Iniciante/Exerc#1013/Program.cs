using System;

namespace Exerc_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            O MAIOR
            Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
            MaiorAB = (a + b + (Math.Abs(a - b))) / 2.0
            Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.
            */  
            int A, B, C, MaiorAB, MaiorTODOS;
            
            string[] entrada = Console.ReadLine().Split(' ');   //Digitar string com os valores de entrada em linha.
            A = int.Parse(entrada[0]);  //Atribuindo valor a A.
            B = int.Parse(entrada[1]);  //Atribuindo valor a B.
            C = int.Parse(entrada[2]);  //Atribuindo valor a S.

            MaiorAB = (A + B + (Math.Abs(A - B))) / 2;  //Usando a fórmula, o comando Math.Abs(<valor>) retorna um valor absoluto do calculo que está entre os parênteses.
                                                        //Cálculo entre o maior de A e B, o resultado mostrará o valor do maior entre eles.
            
            MaiorTODOS = (MaiorAB + C + (Math.Abs(MaiorAB - C))) / 2;   //Cálculo entre o maior de A e B com o C, o resultado mostrará o maior de todos os valores.

            Console.WriteLine(MaiorTODOS + " eh o maior");

            Console.ReadKey();
        }
    }
}
