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
           orcamento.AdicionarItem(new Item("xBox", 500));


           double desconto = cauculador.Calcula(orcamento);
           System.Console.WriteLine(desconto);

        }
    }
}
