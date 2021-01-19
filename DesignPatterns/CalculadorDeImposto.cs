using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double res = imposto.Calcula(orcamento);
            System.Console.WriteLine(res);
        }
            
    }
}