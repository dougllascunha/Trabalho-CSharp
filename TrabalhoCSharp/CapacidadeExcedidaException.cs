

public class CapacidadeExcedidaException : Exception
{
    public CapacidadeExcedidaException()
        : base("Erro: Capacidade máxima do pátio atingida.")
    {
    }

    public CapacidadeExcedidaException(string mensagem)
        : base(mensagem)
    {
    }
}