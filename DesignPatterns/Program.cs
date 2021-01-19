using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
           CalculadorDesconto cauculador =  new CalculadorDesconto();

           Orcamento orcamento = new Orcamento(500);
           orcamento.AdicionarItem(new Item("Caneta", 500));
           orcamento.AdicionarItem(new Item("Lapis", 500));
           orcamento.AdicionarItem(new Item("Geladeira", 500));
           orcamento.AdicionarItem(new Item("Fogão", 500));
           orcamento.AdicionarItem(new Item("Microondas", 500));
           orcamento.AdicionarItem(new Item("Xbox", 500));

            CalculadorDeImposto calculador = new CalculadorDeImposto();
            double imposto = calculador.RealizaCalculo(orcamento, new IHIT());
            System.Console.WriteLine(imposto);

        }
    }
}
