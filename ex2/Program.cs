using System;
using ex2;

namespace ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice();
            v1.posicaox = 0;
            v1.posicaoy = 1;

            Console.WriteLine("A posição do vértice é: ({0},{1})", v1.posicaox, v1.posicaoy);
            Console.ReadLine(); 
        }
    }
}
