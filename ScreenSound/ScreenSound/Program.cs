using System.Linq;

string mensagemDeBoasVindas = "Bem vindo ao Screen Sound\n";

//List<string> bandas = new List<string>() { "Etsuko Yakushimaru", "Home Made Kazoku", "Flow", "BabyMetal", "Rammstein", "DragonForce" }; // instancia uma lista.
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Etsuko Yakushimaru", new List<int>());
bandasRegistradas.Add("Flow", new List<int> { 10, 10, 9});
void ExibirMensagem(string mensagem)
{
    string confete = "*";
    for (global::System.Int32 i = 0; i < 40; i++)
    {
        confete = confete + "*";
    }

    Console.WriteLine($"{confete}\n{mensagem}\n{confete}");
}

//ExibirMensagem(mensagemDeBoasVindas);

void ExibirMenu()
{
    restart:
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

    Console.WriteLine(mensagemDeBoasVindas);

    Console.WriteLine("  (1) - Registrar Banda");
    Console.WriteLine("  (2) - Mostrar todas as Bandas");
    Console.WriteLine("  (3) - Avaliar Banda");
    Console.WriteLine("  (4) - Exibir média de uma Banda");
    Console.WriteLine(" (-1) - sair");

    Console.Write("\nDigite sua Escolha: ");

    int escolha = int.Parse(Console.ReadLine()!);

    switch (escolha)
    {
        case 1:
            RegistrarBanda();
            goto restart;

        case 2:
            MostrarBandas();
            goto restart;

        case 3:
            AvaliarBanda();
            goto restart;

        case 4:
            ExibirMedia();
            goto restart;

        case -1:
            Console.WriteLine($"\nTchau, volte sempre.");
            break;

        default:
            Console.WriteLine("Opção inválida.\n");
            goto restart;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Titulo("Registrar Banda");
    Console.WriteLine("Registro de Bandas\n");
    Console.Write("Digite o nome da Banda: ");
    string banda = Console.ReadLine()!;
    bandasRegistradas.Add( banda, new List<int>() );
    Console.WriteLine($"A banda {banda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
}

void MostrarBandas()
{
    Console.Clear();
    Titulo("Bandas Registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"- {banda}\n");
    }
    Console.Write("\nPressione qualquer tecla para volta para o Menu Principal: ");
    Console.ReadKey();
    Console.Clear();
}
void Titulo(string titulo)
{
    string borda = "";
    foreach (char item in titulo)
    {
        borda += "*";
    }
    Console.WriteLine($"{borda}\n{titulo}\n{borda}\n");
}
void AvaliarBanda()
{
    Console.Clear();
    Titulo("Avaliar Banda");
    Console.Write("\nQual banda deseja avaliar: ");
    string bandaAvaliada = Console.ReadLine()!;

    if ( bandasRegistradas.ContainsKey( bandaAvaliada ))
    {
        Console.Write($"Sua nota para a banda {bandaAvaliada} é: ");
        byte nota = byte.Parse(Console.ReadLine());
        bandasRegistradas[bandaAvaliada].Add(nota);
        Console.WriteLine($"\nA sua avaliação para a banda {bandaAvaliada} foi registrada com sucesso!");
        Thread.Sleep(5000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"\nA banda {bandaAvaliada} não foi encontrada em nosso banco de dados.");
        Console.Write("Pressione qualquer tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
    }
}
float MediaDasNotasDeUmaBanda(string nomeDaBanda)
{
    float media;
    media = (float)bandasRegistradas[nomeDaBanda].Average();
    return media;
}
void ExibirMedia()
{
    Console.Clear();
    Titulo("Média da Avaliação das bandas");
    Console.Write("\nDigite a banda que você deseja ver a avaliação: ");
    string nome = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nome))
    {
        Console.WriteLine($"\nA média da banda {nome} é: {MediaDasNotasDeUmaBanda(nome):N2}");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"A banda {nome} não foi encontrada em nosso banco de dados.");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
    }
}

ExibirMenu();