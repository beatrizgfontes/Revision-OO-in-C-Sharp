using System;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de vértices: ");
            int qtVertice = int.Parse(Console.ReadLine());
            Poligono p1 = new Poligono(qtVertice);

            Console.WriteLine("Perímetro: {0}", p1.perimetro());
            Console.WriteLine("Quantidade de vértices: {0}", p1.Qtlados);
        }
    }
}
