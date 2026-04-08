
using GlobalPorts;


SistemaPortoLegacy porto = new SistemaPortoLegacy();

porto.AdicionarContentor("abv", "Comum", 20.5, true);
porto.AdicionarContentor("abv1", "Comum", 20.5, true);
porto.AdicionarContentor("abv2", "Comum", 20.5, true);
porto.AdicionarContentor("abv3", "Comum", 20.5, true);
porto.AdicionarContentor("abv4", "Comum", 20.5, true);

Console.WriteLine(porto.QtdContentores());

porto.EmbarcarNavio();













