
using GlobalPorts;

public class SistemaPortoLegacy 
{
    // 2. Falha de Coleção: Array de tamanho fixo. Vai quebrar ou perder dados.
    private Dictionary<string, IContentor> _patio = new Dictionary<string, IContentor>();
    private Queue<IContentor> _fila = new Queue<IContentor>();


    public string QtdContentores()

    {
        return "Total de Contentores: " + _patio.Count;
    }
    public void AdicionarContentor(string codigo, string tipo, double peso, bool inspecao) 

    {
        try
        {
            Console.WriteLine($"[LOG] [{DateTime.Now}] Tentando adicionar contentor {codigo}");

      
        if (_patio.Count >= 50)
        {
            throw new CapacidadeExcedidaException();
        }

        
            ContentorLegacy novo = new ContentorLegacy(codigo, tipo, peso, inspecao);

            if (!_patio.ContainsKey(codigo))

            {
                _patio.Add(codigo, novo);
                _fila.Enqueue(novo);

                Console.WriteLine($"[LOG] [{DateTime.Now}] Contentor {codigo} adicionado com sucesso.");
            }

            else

            {
                Console.WriteLine($"[LOG] [{DateTime.Now}] Contentor {codigo} já existe.");
            }
        }
        catch (CapacidadeExcedidaException ex)
        {
            Console.WriteLine($"[LOG] [{DateTime.Now}] Erro ao adicionar contentor: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"[LOG] [{DateTime.Now}] Operação finalizada.");
        }

    }
    public void EmbarcarNavio()

    {

    Console.WriteLine($"[LOG] [{DateTime.Now}] Iniciando embarque...");

    while (_fila.Count > 0)
    {
        var contentor = _fila.Dequeue();

        _patio.Remove(contentor.CodigoRastreio);

        Console.WriteLine($"[LOG] [{DateTime.Now}] Embarcando contentor {contentor.CodigoRastreio}");
    }
    Console.WriteLine($"[LOG] [{DateTime.Now}] Embarque concluído.");

    }



}





