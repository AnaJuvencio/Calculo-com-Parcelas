using System;
using Aula01;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular();

            Console.Write("Informe o valor inicial da parcela => ");
            calcular.valorInicial = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de parcelas => ");
            calcular.qtdParcela = double.Parse(Console.ReadLine());

            Console.Write("O valor final da parcela é => " + calcular.CalcularParcelas());

            Console.ReadKey();
        }
    }
}
