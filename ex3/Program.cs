using System;
using ex2;

namespace ex3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(2, 4);
            Vertice v2 = new Vertice(1, 3);
            Vertice v3 = new Vertice(2, 0);
            Triangulo t1 = new Triangulo(v1,v2,v3);
            Triangulo t2 = new Triangulo(v1, v2, v3);
            Console.WriteLine("O tipo do triângulo é: {0}", t1.Tipo());
            Console.WriteLine("O valor da área é: {0}",t1.calculoArea());
            Console.WriteLine("Os triângulos são iguais? {0}", t1.IgualdadeTriangulo(t2));
            Console.ReadLine();
        }
    }
}
