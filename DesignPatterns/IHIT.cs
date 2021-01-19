using System.Collections.Generic;

namespace DesignPatterns
{
    public class IHIT : TemplateImposto
    {
        protected override double MaxTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100; 
        }

        protected override double MinTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        protected override bool UsarTaxaMax(Orcamento orcamento)
        {
            List<string> tempList = new List<string>();
            foreach (var item in orcamento.Itens)
            {
                
                if(tempList.Contains(item.Nome))
                {
                    System.Console.WriteLine("true");
                    return true;
                }
                tempList.Add(item.Nome);
            }
        System.Console.WriteLine("false");
            return false;
        }
    }
}