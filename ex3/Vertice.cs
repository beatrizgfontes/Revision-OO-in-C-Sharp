using System;

namespace ex3
{
    public class Vertice
    {
        private float _x;
        private float _y;
        private string _nome;

        private float setx
        {
            set { _x = value; }
        }
        public float getx
        {
            get { return _x; }
        }
        private float sety
        {
            set { _y = value; }
        }
        public float gety
        {
            get { return _y; }
        }

        private string setNome
        {
            set { _nome = value; }
        }
        public string getNome
        {
            get { return _nome; }
        }
        public Vertice() {
            this.setx = 0;
            this.sety = 0;
        }
        public Vertice(float x, float y, string nome)
        {
            this.setx = x;
            this.sety = y;
            this.setNome = nome;
            Console.WriteLine("O vértice {0} foi criado! = ({1};{2})", this.getNome,this.getx, this.gety);
        }

        public float distancia(float x1, float y1, float x2, float y2) {
            float d, dist;
            d = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
            dist = (float)Math.Sqrt(d);
            return dist;
        }

        public void move()
        {
            Console.WriteLine("Informe a  nova posição de x e y respectivamente: ");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            this.setx = x;
            this.sety = y;
        }

        public bool iguais(float x1, float y1, float x2, float y2)
        {
            bool igual;
            if(x1 == x2 && y1 == y2)
            {
                igual = true;
            }
            else
            {
                igual= false;
            }
            return igual;
        }
    }
}
