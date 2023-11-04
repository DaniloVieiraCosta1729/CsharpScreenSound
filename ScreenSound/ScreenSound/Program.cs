string mensagemDeBoasVindas = "Bem vindo ao Screen Sound";

void ExibirMensagem(string mensagem)
{
    string confete = "*";
    for (global::System.Int32 i = 0; i < 40; i++)
    {
        confete = confete + "*";
    }

    Console.WriteLine($"{confete}\n{mensagem}\n{confete}");
}

ExibirMensagem(mensagemDeBoasVindas);
