namespace DesignPatterns
{
    public class ICPP : TemplateImposto

    {

        protected override double MaxTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override bool UsarTaxaMax(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
    }
}