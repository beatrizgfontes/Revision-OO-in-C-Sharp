using System;

namespace ex2
{
    public class Vertice
    {
        private float x;
        private float y;

        public float posicaox
        {
            get { return x; }
            set { x = value; }
        }
        public float posicaoy
        {
            get { return y; }
            set { y = value; }
        }

        public Vertice() {
            this.x = 0;
            this.y = 0;
        }
    }
}
