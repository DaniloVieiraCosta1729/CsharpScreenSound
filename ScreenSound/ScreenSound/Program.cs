string mensagemDeBoasVindas = "Bem vindo ao Screen Sound\n";

Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

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

Console.WriteLine(mensagemDeBoasVindas);

void ExibirMenu()
{
    Console.WriteLine("  (1) - Registrar Banda");
    Console.WriteLine("  (2) - Mostrar todas as Bandas");
    Console.WriteLine("  (3) - Avaliar Banda");
    Console.WriteLine("  (4) - Exibir média de uma Banda");
    Console.WriteLine(" (-1) - sair");

    Console.Write("Digite sua Escolha: ");

    int escolha = int.Parse(Console.ReadLine())!;

    switch (escolha)
    {
        case 1:
            Console.WriteLine($"Você escolheu a opção {escolha}.");
            break;

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
            Console.WriteLine($"Você escolheu a opção {escolha}.");
            break;

        default:
            break;
    }
}
ExibirMenu();