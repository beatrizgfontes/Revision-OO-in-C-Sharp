using System;
using System.Runtime.CompilerServices;
using ex2;

namespace ex3
{
    public class Triangulo
    {
        private float lado1;
        private float lado2;
        private float lado3;
        private float _perimetro;
        private float _area;

        //Propriedades dos Vértices
        public Vertice V1 { get; private set; }
        public Vertice V2 { get; private set; }
        public Vertice V3 { get; private set; }

        //Inicializando o triângulo
        public Triangulo(Vertice v1, Vertice v2, Vertice v3)
        {
            this.lado1 = v1.distancia(v2);
            this.lado2 = v2.distancia(v3);
            this.lado3 = v3.distancia(v1);

            //Ver se realmente é um triângulo
            if ((lado1 + lado2 < lado3) || (lado1 + lado3 < lado2) || (lado2 + lado3 < lado1))
                throw new Exception("Não é um triangulo!");

            V1 = v1;
            V2 = v2;
            V3 = v3;

            this.Perimetro = lado1 + lado2 + lado3;
        }

        //Propriedade do perímetro
        private float Perimetro
        {
            get { return _perimetro; }
            set { _perimetro = value;}
        }

        //Propriedade da área
        private float Area
        {
            get { return _area; }
            set { _area = value; }
        }

        //Vendo se os triângulos são iguais
        public bool IgualdadeTriangulo(Triangulo t2)
        {
            if ((this.lado1 == t2.lado1) && (this.lado2 == t2.lado2) && (this.lado3 == t2.lado3))
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

        //Método para calcular a área
        public float calculoArea()
        {
            float semiperimetro = (this.Perimetro) / 2;
            float x = semiperimetro * (semiperimetro - this.lado1) * (semiperimetro - this.lado2) * (semiperimetro - this.lado3);
            this.Area = (float)Math.Sqrt(x);
            return this.Area;
        }

        //Método para verificar o tipo
        public string Tipo()
        {
            string tp = "";
            
            if ((this.lado1 == this.lado2) && (this.lado1 == this.lado3))
            {
                tp = "Equilatero";
                return tp;
            }
            else if ((this.lado1 == this.lado2) || (this.lado1 == this.lado3) || (this.lado2 == this.lado3))
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
    }
}
