
namespace GlobalPorts;


public class ContentorLegacy: IContentor
{
    private string _CodigoRastreio;            
    private string _TipoMaterial;                   
    private double _PesoToneladas;
    private bool _IsAprovadoInspecao;

    public string CodigoRastreio
    {
        get { return _CodigoRastreio; }
        set { _CodigoRastreio = value?? throw new ArgumentNullException(nameof(CodigoRastreio), "O código de rastreio não pode ser nulo."); }
    }
    public string TipoMaterial
    {
        get { return _TipoMaterial; }
        set { _TipoMaterial = value?? throw new ArgumentNullException(nameof(TipoMaterial), "O tipo de material não pode ser nulo."); }
    }
    public double PesoToneladas
    {
        get { return _PesoToneladas; }
        set { 
            
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(PesoToneladas), "O peso não pode ser menor que 0 !!!");
            }
            _PesoToneladas = value;

            }
       
    }
    public bool IsAprovadoInspecao
    {
        get { return _IsAprovadoInspecao; }
        set { _IsAprovadoInspecao = value; }
    }

    public ContentorLegacy(string codigo, string tipo, double peso, bool inspecao)
    {
        CodigoRastreio = codigo;
        TipoMaterial = tipo;
        PesoToneladas = peso;
        IsAprovadoInspecao = inspecao;
    }  
}

