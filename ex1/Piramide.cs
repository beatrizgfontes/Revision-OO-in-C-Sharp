using System;

namespace ex1
{
    public class Piramide
    {
        public int _n;
        //Criando propriedade N
        public int N
        {
            get { return _n; }
            set 
            {
                //Tratando a exeção
                if (value < 1)
                    throw new Exception("Por favor informe um valor maior ou igual a 1!");
                _n = value;
            }
        }
        //Inicializando a pirâmide
        public Piramide(int n)
        {
            try
            {
                this.N = n;
                Console.WriteLine("Valor de n é: {0}",this.N);
            }catch(Exception e){
                Console.WriteLine("Erro: {0}", e.Message);
            }
        }
        //Método desenhar
        public void desenhar()
        {
            for (int i = 0; i < N; i++)
            {
                //Espaçamentos
                for (int j = 0; j < N-i; j++)
                {
                    Console.Write(' ');
                }
                //Números crescentes
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j+1);
                }
                //Números decrescentes
                for (int j = i-1; j >= 0; j--)
                {
                    Console.Write(j+1);
                }

                Console.WriteLine();
            }
        }
    }
}
