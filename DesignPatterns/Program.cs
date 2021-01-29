using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
          Orcamento reforma = new Orcamento(500);
          reforma.AplicaDescontoExtra();
        }
    }
}
