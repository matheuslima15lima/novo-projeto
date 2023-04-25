using cadastro_alunos;


Aluno al = new Aluno();


Console.WriteLine($"informe seu nome");
al.nome = Console.ReadLine();

Console.WriteLine($"informe o curso");
al.curso = Console.ReadLine();

Console.WriteLine($"digite sua idade");
al.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"digite seu rg");
al.RG = Console.ReadLine();

Console.WriteLine($"voce e bolsista? s/n");
string respBolsista = Console.ReadLine().ToLower();

Console.WriteLine($"diga sua media final");
al.mediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"informe o valor da mensalidade");
al.mensalidade = float.Parse(Console.ReadLine());







switch (respBolsista)
{
    case "n":
        al.bolsista = false;

        Console.WriteLine($"sua mensalidade ficou {al.mensalidade}");

        break;

    case "s":
        al.bolsista = true;
        if (al.mediaFinal >= 8)
        {
            Console.WriteLine($"sua mensalidade ficou {al.mensalidade * 0.5f}");

        }

        else if (al.mediaFinal > 6)
        {
            Console.WriteLine($"sua mensalidade ficou {al.mensalidade * 0.7f}");
        }

        else
        {
            Console.WriteLine($"a sua mensalidade ficou {al.mensalidade}");

        }

        break;

    default:
        Console.WriteLine($"opcao invalida");

        break;
}


// float porcentagemValor = al.mensalidade * 0.5f;
string opcao;
do
{
 Console.WriteLine($@"

  quer visualizar a media e o valor da mensalidade?
    {1} media
    {2} valor da mensalidade
    {0} sair
");

opcao = Console.ReadLine();
switch (opcao)
{
    case "1":
        // exemplo do professor
        // float md = al.VerMediaFinal();

        // md = md + 2;
        // Console.WriteLine($"Media ganhou mais 2: {md}");

        Console.WriteLine($"a media do aluno {al.nome} e: {al.VerMediaFinal()}");
        break;

    case "2":
        
        Console.WriteLine($"a mensalidade e de  {al.VerMensalidade()}");
        break;

        case "0":
        Console.WriteLine($"fim");
        break;

    default:
        Console.WriteLine($"opcao invalida");

        break;
}   
} while (opcao != "0");



// Só que esta conta vai retornar 50% da média. E o que o exercício quer é a mensalidade - 50%, então,
//  no caso, você teria que criar uma variável no cálculo de antes. Vai ficar assim:
// float porcentagemValor = al.mensalidade * 0.5f  --> Isso guardará o valor de 50% da mensalidade
// al.mensalidade = al.mensalidade - porcentagemValor --> Isso subtrairá 50% do valor.


