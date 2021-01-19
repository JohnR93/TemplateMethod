namespace DesignPatterns
{
    public class DescontoMaisQuinhetosReias : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {           
            if(orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}