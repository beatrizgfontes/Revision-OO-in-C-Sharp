using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //Console.WriteLine(piramide1.n);
            
            Console.ReadLine();
        }
    }
}
