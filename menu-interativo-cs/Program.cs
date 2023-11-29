string? opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente ");
    Console.WriteLine("1 - Buscar cliente ");
    Console.WriteLine("1 - Apagar cliente ");
    Console.WriteLine("1 - Encerrar ");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar cliente");
            break;
        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            // Environment.Exit(0);
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}