string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");

    Console.WriteLine($"{mensagemDeBoasVindas}\n\r");

    ExibirOpcoesDoMenu();

    Console.Write("Digite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoNumerica)
    {
        case 1: 
            Console.WriteLine("Você Digitou 1");
            break;
        case 2:
            Console.WriteLine("Você Digitou 2");
            break;
        case 3:
            Console.WriteLine("Você Digitou 3");
            break;
        case 4:
            Console.WriteLine("Você Digitou 4");
            break;
        case 0:
            Console.WriteLine("Tchau");
            break;
        default:
            Console.WriteLine("ainda não tem essa opção");
            break;
    }
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("1. Registrar Banda");
    Console.WriteLine("2. Mostrar Banda");
    Console.WriteLine("3. Avaliar Uma Banda");
    Console.WriteLine("4. Média de uma Banda");
    Console.WriteLine("0. Sair");
    Console.WriteLine("");
}
ExibirMensagemDeBoasVindas();