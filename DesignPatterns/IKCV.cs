namespace DesignPatterns
{
    public class IKCV : TemplateImposto
    {

        protected override double MaxTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override bool UsarTaxaMax(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100(orcamento);
        }

        private bool TemItemMaiorQue100(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if(item.Valor > 100)
                    return true;
            }
            return false;
        }
    }
}