public class ContentorToxico : Imposto
{
    public ContentorToxico(string codigo, double peso, bool inspecao)
        : base(codigo, "Toxico", peso, inspecao)
    {
    }

    public override double CalcularImposto()
    {
        return PesoToneladas * 50.0;
    }
}