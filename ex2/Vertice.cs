using System;

namespace ex2
{
    public class Vertice
    {
        private float x;
        private float y;

        private float setx
        {
            set { x = value; }
        }
        public float getx
        {
            get { return x; }
        }
        private float sety
        {
            set { y = value; }
        }
        public float gety
        {
            get { return y; }
        }
        public Vertice() {
            this.setx = 0;
            this.sety = 0;
        }
        public Vertice(float x, float y)
        {
            this.setx = x;
            this.sety = y;
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
