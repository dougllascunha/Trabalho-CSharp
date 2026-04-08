public abstract class Imposto : IContentor
{
    public string CodigoRastreio { get; protected set; }
    public string TipoMaterial { get; protected set; }
    public double PesoToneladas { get; protected set; }
    public bool IsAprovadoInspecao { get; protected set; }

    public Imposto(string codigo, string tipo, double peso, bool inspecao)
    {
        CodigoRastreio = codigo;
        TipoMaterial = tipo;
        PesoToneladas = peso;
        IsAprovadoInspecao = inspecao;
    }
    public abstract double CalcularImposto();
}

 