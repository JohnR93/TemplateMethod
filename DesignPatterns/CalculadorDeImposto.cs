using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class CalculadorDeImposto
    {
        public double RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double res = imposto.Calcula(orcamento);
            return res;
        }
            
    }
}