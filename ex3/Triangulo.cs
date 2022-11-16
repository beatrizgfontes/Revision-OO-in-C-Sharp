using System;
using System.Runtime.CompilerServices;
//using ex2;

namespace ex3
{
    public class Triangulo : Vertice
    {
        private float _x;
        private float _y;
        private float l1;
        private float l2;
        private float l3;
        private float _perimetro;
        private float _area;
        
        public Triangulo() { 
            this.criarVertice(0, 0, "0");
            this.criarVertice(0, 0, "0");
            this.criarVertice(0, 0, "0");

            Console.WriteLine("Informe o tamanho dos lados do triângulo: ");
            this.l1 = float.Parse(Console.ReadLine());
            this.l2 = float.Parse(Console.ReadLine());
            this.l3 = float.Parse(Console.ReadLine());

            this.Perimetro = this.l1 + this.l2 + this.l3;
        }
        public Triangulo(float x1, float y1, string nome1, float x2, float y2, string nome2, float x3, float y3, string nome3)
        {
            this.criarVertice(x1,y1, nome1);
            this.criarVertice(x2,y2, nome2);
            this.criarVertice(x3,y3, nome3);

            Console.WriteLine("Informe o tamanho dos lados do triângulo: ");
            this.l1 = float.Parse(Console.ReadLine());
            this.l2 = float.Parse(Console.ReadLine());
            this.l3 = float.Parse(Console.ReadLine());

            this.Perimetro = this.l1 + this.l2 + this.l3;
        }

        private float Perimetro
        {
            get { return _perimetro; }
            set { _perimetro = value;}
        }

        private float Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public bool IgualdadeTriangulo(Triangulo x, Triangulo y)
        {
            if ((x.l1 == y.l1) && (x.l2 == y.l2) && (x.l3 == y.l3))
            {
                bool igual = true;
                return igual;
            }
            else
            {
                bool igual = false;
                return igual;
            }
        }

        public float calculoArea()
        {
            float semiperimetro = (this.Perimetro) / 2;
            float x = semiperimetro * (semiperimetro - this.l1) * (semiperimetro - this.l2) * (semiperimetro - this.l3);
            this.Area = (float)Math.Sqrt(x);
            return this.Area;
        }

        public string Tipo()
        {
            string tp = "";
            if ((this.l1 + this.l2 < this.l3) || (this.l1 + this.l3 < this.l2) || (this.l2 + this.l3 < this.l1))
            {
                tp = "Não é um triangulo!";
                return tp;
            }
            else if ((this.l1 == this.l2) && (this.l1 == this.l3))
            {
                tp = "Equilatero";
                return tp;
            }
            else if ((this.l1 == this.l2) || (this.l1 == this.l3) || (this.l2 == this.l3))
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
        }
}
