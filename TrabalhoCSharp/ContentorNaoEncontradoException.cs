using System;

public class ContentorNaoEncontradoException : Exception
{
    public ContentorNaoEncontradoException()
        : base("Erro: Contentor não encontrado.")
    {
    }

    public ContentorNaoEncontradoException(string mensagem)
        : base(mensagem)
    {
    }
}