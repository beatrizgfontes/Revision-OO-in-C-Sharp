using System;

namespace ex5
{
    public class Intervalo
    {
        private string dataInicio;
        private string datafinal;
        private string horaInicio;
        private string horaFinal;

        public Intervalo(int dia, int mes, int ano)
        {
            var dataInicio = new DateTime(ano, mes, dia);
            var dataFinal = new DateTime(ano, mes, dia);
            var dataInicio = new DateTime(ano, mes, dia);
            var dataInicio = new DateTime(ano, mes, dia);
            Console.WriteLine(dataInicio.ToString());
        }
    }
}
