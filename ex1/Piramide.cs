using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class Piramide
    {
        public int _n;

        public int N
        {
            get { return _n; }
            set { _n = value; }
        }
        public Piramide(int n)
        {
            try
            {
                if (n < 1)
                {
                    throw new Exception("Por favor informe um valor maior ou igual a 1!");
                }
                this.N = n;
                Console.WriteLine("Valor de n é: {0}",this.N);
            }catch(Exception e){
                Console.WriteLine("Erro: {0}", e.Message);
            }
        }

        public void desenhar(int n)
        {

        }
    }
}
