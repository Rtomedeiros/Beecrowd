using System;

namespace Exerc_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CONSUMO
            Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).
            Entrada: O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), 
            e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.
            Saída: Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
            */
            int X;          //X = Distância Total percorrida (em Km).
            double Y, CON;  //Y = Combustível gasto (em litros), CON = Consumo médio (Km/l).

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            CON = X / Y;

            Console.Write("{0:F3}", CON);
            Console.WriteLine(" km/l");       

            Console.ReadKey();
        }
    }
}
