public class ContentorRefrigerado : Imposto
{
    public ContentorRefrigerado(string codigo, double peso, bool inspecao)
        : base(codigo, "Refrigerado", peso, inspecao)
    {
    }

    public override double CalcularImposto()
    {
        return PesoToneladas * 25.0;
    }
}