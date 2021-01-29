namespace DesignPatterns
{
    public class Finalizado : EstadoDoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new System.Exception("Orçamentos finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento já está finalizado");
        }
    }
}