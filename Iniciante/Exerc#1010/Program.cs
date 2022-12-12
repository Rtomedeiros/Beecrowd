using System;

namespace Exerc_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cálculo Simples
            Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
            o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
            Após, calcule e mostre o valor a ser pago.
            */

            int CP1, NP1, CP2, NP2; //CP = Código da peça, NP = Número de peças.
            double VU1, VU2, VT; //VU = Valou unitário da peça, VT = Valor total.

            //Comandos que divide os caracteres em uma string digitada através do console. 
            //Neste caso a divisão será feita pelos espaços entre os valores referentes a cada peça.
            string[] valores1 = Console.ReadLine().Split(' ');  //1ª linha de valores Peça 1.
            string[] valores2 = Console.ReadLine().Split(' ');  //2ª linha de valores Peça 2.

            CP1 = int.Parse(valores1[0]);   //Atribuindo o 1º valor referente a CP da Peça 1.
            NP1 = int.Parse(valores1[1]);   //Atribuindo o 2º valor referente a NP da Peça 1.
            VU1 = double.Parse(valores1[2]);    //Atribuindo o 3º valor referente a VU da Peça 1.

            CP2 = int.Parse(valores2[0]);   //Atribuindo o 1º valor referente a CP da Peça 2.
            NP2 = int.Parse(valores2[1]);   //Atribuindo o 2º valor referente a NP da Peça 2.
            VU2 = double.Parse(valores2[2]);    //Atribuindo o 3º valor referente a VU da Peça 2.

            VT = (NP1 * VU1) + (NP2 * VU2);

            Console.WriteLine("VALOR A PAGAR: R$ "+ "{0:F2}", VT);

            Console.ReadKey();
        }
    }
}
