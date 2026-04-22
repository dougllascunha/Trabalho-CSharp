



SistemaPortoLegacy sistema = new();

while (true) 
{
    

Console.WriteLine("================ MENU PORTO LEGACY =================");
Console.WriteLine("1. Adicionar novo contentor");
Console.WriteLine("2. Quantidades de contentores");
Console.WriteLine("0. Para sair !!!");

Console.Write("Digite a opção desejada: ");
int opcao = int.Parse(Console.ReadLine());

if (opcao == 0)
{
    Console.WriteLine("Obrigado por ultilizar !!!");
    break;
}
switch (opcao)
{
        case 1:


        Console.Write("Digite o Codigo do Contentor: ");
        string codigo = Console.ReadLine();

        Console.Write("Digite o Tipo do conteudo: (Comum/Refrigerado/Toxico)");
        string tipo = Console.ReadLine();

        sistema.AdicionarContentor(codigo,tipo,2,true);
        
        break;

        case 2:
        
        Console.WriteLine(sistema.QtdContentores());

        break;

        default:

        Console.WriteLine("Tipo inválido");
        Console.WriteLine("Digite um valor válido !!!");


        break;
}

}
