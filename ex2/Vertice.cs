using System;

namespace ex2
{
    public class Vertice
    {
        //Propriedades de x e y
        public float X { get; private set; }
        public float Y { get; private set; }

        //Inicializando o Vértice
        public Vertice(float x, float y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine("O vértice foi criado! = ({0};{1})",this.X, this.Y);
        }
        //Método distância
        public float distancia(Vertice v2) {
            float d, dist;
            d = (this.X - v2.X) * (this.X - v2.X) + (this.Y - v2.Y) * (this.Y - v2.Y);
            dist = (float)Math.Sqrt(d);
            return dist;
        }
        //Método move
        public void move(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        //Vendo se os vértices são iguais
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
