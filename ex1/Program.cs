using System;
using ex1;

namespace ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Informe o valor de N: ");
            n = int.Parse(Console.ReadLine());

            Piramide piramide1= new Piramide(n);
            piramide1.desenhar(n);
            
            Console.ReadLine();
        }
    }
}
