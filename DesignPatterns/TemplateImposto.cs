namespace DesignPatterns
{
    public abstract class TemplateImposto : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if(UsarTaxaMax(orcamento))
            {
                return MaxTaxa(orcamento);
            }
            return MinTaxa(orcamento);
        }

        protected abstract bool UsarTaxaMax(Orcamento orcamento);
        protected abstract double MaxTaxa(Orcamento orcamento);
        protected abstract double MinTaxa(Orcamento orcamento);
    }
}