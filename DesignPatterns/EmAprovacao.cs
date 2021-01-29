namespace DesignPatterns
{
    public class EmAprovacao : EstadoDoOrcamento
    {
        private bool descontoDado;
        
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if(!descontoDado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                return;
            }
            throw new System.Exception("Desconto já foi dado");.
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento em aprovação não pode ir para finalizado direto");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}