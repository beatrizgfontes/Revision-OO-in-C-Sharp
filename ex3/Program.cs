using System;
using ex2;

namespace ex3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Triangulo t1 = new Triangulo(2, 2, "A", 4, 1, "B", 5, 6, "C");
            Triangulo t2 = new Triangulo(2, 2, "A", 4, 1, "B", 5, 6, "C");
            Console.WriteLine("O tipo do triângulo é: {0}", t1.Tipo());
            Console.WriteLine("O valor da área é: {0}",t1.calculoArea());
            Console.WriteLine("Os triângulos são iguais? {0}", t1.IgualdadeTriangulo(t1,t2));
            Console.ReadLine();
        }
    }
}
