namespace DesignPatterns
{
    public class CalculadorDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            Desconto d1 = new DescontoCincoItens();
            Desconto d2 = new DescontoMaisQuinhetosReias();
            Desconto d3 = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;
            return d1.Desconta(orcamento);
        }
    }
}