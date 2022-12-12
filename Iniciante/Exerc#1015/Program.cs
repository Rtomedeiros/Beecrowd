using System;

namespace Exerc_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DISTÂNCIA ENTRE DOIS PONTOS
            Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, 
            mostrando 4 casas decimais após a vírgula, segundo a fórmula:
            Distancia = Math.Sqrt(((x2 - X1) * (x2 - X1)) + ((y2 - y1) * (y2 - y1)));
            Entrada: O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: 
            x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.
            Saída: Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
            */
            double x1, y1, x2, y2, DIS;

            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(p1[0]);
            y1 = double.Parse(p1[1]);

            x2 = double.Parse(p2[0]);
            y2 = double.Parse(p2[1]);
            
            DIS = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.WriteLine("{0:F4}", DIS);

            Console.ReadKey();
        }
    }
}
