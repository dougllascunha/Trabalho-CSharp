
public class ContentorComum : Imposto
{
    public ContentorComum(string codigo, double peso, bool inspecao)
        : base(codigo, "Comum", peso, inspecao)
    {
    }

    public override double CalcularImposto()
    {
        return PesoToneladas * 10.5;
    }
}