using Projeto_Celular;

Celular cell = new Celular();

Console.WriteLine($"O celular está ligado ? true/false");
cell.Ligado = bool.Parse(Console.ReadLine());

if (cell.Ligado == true)
{
    string opcao;

    do
    {
        Console.WriteLine($@"
    opcoes:
    [1] ligar
    [2] mandar mensagem
    [3] fazer ligacao
    [0] desligar
    ");

        opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                cell.LigarCelular();
                break;
            case "2":
                cell.EnviarMensagem();
                break;
            case "3":
                cell.FazerLigacao();
                break;
            case "0":
                cell.Desligar();
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine($"opcao invalida!");
                break;
        }

    } while (opcao != "0");
}
else
{
    Console.WriteLine($"Celular está desligado...favor ligar...");    
}





