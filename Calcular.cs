using System;
using System.Collections.Generic;
using System.Text;
using Aula01;

namespace Aula01
{
    public class Calcular
    {
        public double qtdParcela, valorInicial, valorqFinal, resultado;

        public double CalcularParcelas() 
        {
            if(qtdParcela >= 5)
            {
                valorqFinal = (valorInicial / qtdParcela);
                resultado = valorqFinal + (1 * valorqFinal / 100);
                
            }
            return (resultado);
        }
    }
}
