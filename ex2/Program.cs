using System;
using ex2;

namespace ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(2,2);
            Vertice v2 = new Vertice(2,2);

            float distancia = v1.distancia(v2);

            Console.WriteLine("A Distância euclidiana entre os 2 pontos é: {0}", distancia);
            Console.WriteLine("Informe a  nova posição de x e y respectivamente: ");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            v1.move(x,y);
            bool igual = v1.iguais(v1.X, v1.Y, v2.X, v2.Y);
            Console.WriteLine("A nova posição do vértice é: ({0};{1})", v1.X, v1.Y);
            Console.WriteLine("Os vértices são iguais? {0}", igual);

            Console.ReadLine();
        }
    }
}
