using System;
using System.Runtime.CompilerServices;
//using ex2;

namespace ex3
{
    public class Triangulo : Vertice
    {
        private float _x;
        private float _y;
        private float _perimetro;

        
        public Triangulo() { 
            this.criarVertice(0, 0, "0");
            this.criarVertice(0, 0, "0");
            this.criarVertice(0, 0, "0");
            this.Perimetro = 0;

            Console.WriteLine("Informe o tamanho dos lados do triângulo: ");
            float l1 = float.Parse(Console.ReadLine());
            float l2 = float.Parse(Console.ReadLine());
            float l3 = float.Parse(Console.ReadLine());

            string x = Igualdade(l1, l2, l3);
            Console.WriteLine("O tipo do trinângulo é: {0}", x);
        }
        public Triangulo(float x1, float y1, string nome1, float x2, float y2, string nome2, float x3, float y3, string nome3, float p)
        {
            this.criarVertice(x1,y1, nome1);
            this.criarVertice(x2,y2, nome2);
            this.criarVertice(x3,y3, nome3);
            this.Perimetro = p;

            Console.WriteLine("Informe o tamanho dos lados do triângulo: ");
            float l1 = float.Parse(Console.ReadLine());
            float l2 = float.Parse(Console.ReadLine());
            float l3 = float.Parse(Console.ReadLine());

            string x = Igualdade(l1, l2, l3);
            Console.WriteLine("O tipo do trinângulo é: ",x);
        }

        public float Perimetro
        {
            get { return _perimetro; }
            set { _perimetro = value;}
        }

        public string Igualdade(float l1, float l2, float l3)
        {
            string tp = "";
            if ((l1 + l2 < l3) || (l1 + l3 < l2) || (l2 + l3 < l1))
            {
                tp = "Não é um triangulo!";
                return tp;
            }
            else if ((l1 == l2) && (l1 == l3))
            {
                tp = "Equilatero";
                return tp;
            }
            else if ((l1 == l2) || (l1 == l3) || (l2 == l3))
            {
                tp = "Isóceles";
                return tp;
            }
            else
            {
                tp = "Escaleno";
                return tp;
            }
            
        }
            

        public Vertice criarVertice(float x, float y, string nome)
        {
            return new Vertice(x, y, nome);
        }

            /*public float Tipo(float x1, float y1, float x2, float y2)
            {
                if(igualdade(x1,y1,x2,y2) == this.igualdade(x1, y1, x2, y2))
                {

                }
                return tp;
                //get { return _tipo; }
            }*/

            /*public Vertice criarVertice(float x, float y) {

                return new Vertice(x,y);
            }*/


        }
}
