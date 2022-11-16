using ex3;
using System;

namespace ex4
{
    public class Poligono : Vertice
    {
        public float x;
        public float y;
        public string nome;
        private float _perimetro;
        private float[] tmLados;
        private int _qtlados;

        public Poligono(int nVertice)
        {
            this._qtlados = nVertice;
            //CRIANDO OS VÉRTICES
            for(int i = 0; i < nVertice; i++)
            {
                try
                {
                    if (nVertice < 3)
                    {
                        throw new Exception("O polígono precisa ter ao menos 3 vértices!");
                    }
                    Console.WriteLine("Informe o valor x, y e o nome dos vértices, respectivamente: ");
                    x = float.Parse(Console.ReadLine());
                    y = float.Parse(Console.ReadLine());
                    nome = Console.ReadLine();
                    this.criarVertice(x, y, nome);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: {0}", e.Message);
                }
            }
            Console.WriteLine("Informe o tamanho dos lados do polígono: ");
            tmLados = new float[_qtlados];
            //ADICIONANDO TAMANHO DOS LADOS NO ARRAY
            for(int i = 0; i < _qtlados; i++)
            {
                tmLados[i] = float.Parse(Console.ReadLine());
            }
            //CALCULANDO PERÍMETRO
            this.Perimetro = tmLados[0] + tmLados[1] + tmLados[2];
        }

        public int Qtlados
        {
            get { return _qtlados; }
            set { _qtlados = value; }
        }

        private float Perimetro
        {
            get { return _perimetro; }
            set { _perimetro = value; }
        }
        public float perimetro()
        {
            return this.Perimetro;
        }

        /*public bool AddVertice(float x, float y, string nome)
        {
            if (v.getx)
            {
                for(int i = 0; int < )
                return criarVertice(x, y, nome);
            }
            else
            {
                return false;
            }
        }

        public void removeVertice(float x, float y, string nome)
        {
            if (v.getx)
            {

            }
            else
            {
                Console.WriteLine("Vértice não encontrado!");
            }
        }*/

        public Vertice criarVertice(float x, float y, string nome)
        {
            return new Vertice(x, y, nome);
        }

    }
}
