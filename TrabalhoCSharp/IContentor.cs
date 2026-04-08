public interface IContentor
{
    string CodigoRastreio { get; }
    string TipoMaterial { get; }
    double PesoToneladas { get; }
    bool IsAprovadoInspecao { get; }
}