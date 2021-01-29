namespace DesignPatterns
{
    public interface EstadoDoOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
}