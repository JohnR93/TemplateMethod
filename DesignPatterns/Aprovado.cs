namespace DesignPatterns
{
    public class Aprovado : EstadoDoOrcamento
    {
        private bool descontoDado;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if(!descontoDado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoDado = true;
                return;      
            }
            throw new System.Exception("Desconto já foi dado");

        }

        public void Aprova(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento já está em aprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento está em aprovado não pode ser reprovado agora");
        }
    }
}