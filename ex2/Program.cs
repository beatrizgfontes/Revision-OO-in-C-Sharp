using System;
using ex2;

namespace ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(2,3);
            Vertice v2 = new Vertice(1,1);


            float distancia = v1.distancia(v1.getx, v1.gety, v2.getx, v2.gety);

            Console.WriteLine("A posição do vértice 1 é: ({0};{1})", v1.getx, v1.gety);
            Console.WriteLine("A posição do vértice 2 é: ({0};{1})", v2.getx, v2.gety);
            Console.WriteLine("A Distância euclidiana entre os 2 pontos é: {0}", distancia);
            Console.ReadLine();
        }
    }
}
