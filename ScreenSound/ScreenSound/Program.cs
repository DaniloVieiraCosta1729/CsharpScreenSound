string mensagemDeBoasVindas = "Bem vindo ao Screen Sound\n";

List<string> bandas = new List<string>(); // instancia uma lista.

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
            Console.WriteLine($"Você escolheu a opção {escolha}.");
            break;

        case 3:
            Console.WriteLine($"Você escolheu a opção {escolha}.");
            break;

        case 4:
            Console.WriteLine($"Você escolheu a opção {escolha}.");
            break;

        case -1:
            Console.WriteLine($"Tchau, volte sempre.");
            break;

        default:
            Console.WriteLine("Opção inválida.\n");
            goto restart;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas\n");
    Console.Write("Digite o nome da Banda: ");
    string banda = Console.ReadLine()!;
    bandas.Add( banda );
    Console.WriteLine($"A banda {banda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
}

ExibirMenu();