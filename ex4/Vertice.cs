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

    }
}
