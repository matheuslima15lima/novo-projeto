// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: 
// Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário 
// voltar ao menu anterior(S/N).



// string senhaCorreta = "podeser";


// Console.WriteLine($"digite a senha");
// string senha = Console.ReadLine();


// while (senha != "podeser")
// {
//     Console.WriteLine($"erro senha incorreta");

// }








static bool login(string senha)
{
    if (senha == "podeser")
    {
        return true;
    }
    else
    {
        Console.WriteLine($"senha incorreta!");

        return false;
    }
}




//declarar variaveis
string[] nomes = new string[2];
string[] origens = new string[2];
string[] destinos = new string[2];
DateOnly[] datas = new DateOnly[2];

bool senhaValida;

do
{
    Console.WriteLine($"digite a senha");
    string senha = Console.ReadLine();

    senhaValida = login(senha);

} while (senhaValida != true);


//criar menu de opcoes
Console.WriteLine($"menu de opcoes");
Console.WriteLine($@"

selecione uma das opcoes
[1] - Cadastrar
[2] - Listar
[0] - Sair
");

string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    string resposta = "";
        do
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"informe o nome");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"informe seu pais de origem: ");
                origens[i] = Console.ReadLine();

                Console.WriteLine($"informe seu destino: ");
                destinos[i] = Console.ReadLine();

                Console.WriteLine($"informe a data: ");
                datas[i] = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine($"deseja cadastrar mais uma passagem? S/N");
                resposta = Console.ReadLine().ToLower();
            }
        } while (resposta == "s");
        break;
        case "2":
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine(@$"
                *******************
                Passagens - Bilhete

                Nome: {nomes[i]}
                Origem: {origens[i]}
                Destino: {destinos[i]}
                Data: {datas[i]}
                ");
            }
                break;
    
            case "0":
            Console.WriteLine($"Fim do programa");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            
        break;
    
}



// inicioCadastro:
// for (int i = 0; i < 2; i++)
// {
//     Console.WriteLine($"informe seu nome ");
//     string nm = Console.ReadLine();

//     Console.WriteLine($"informe seu pais de origem: ");
//     string or = Console.ReadLine();

//     Console.WriteLine($"informe seu destino: ");
//     string dn = Console.ReadLine();

//     Console.WriteLine($"informe a data: ");
//     DateOnly dt = DateOnly.Parse(Console.ReadLine());


//     nomes[i] = nm;
//     origens[i] = or;
//     destinos[i] = dn;
//     datas[i] = dt;

// }

// Console.WriteLine($"deseja cadastrar mais uma passagem? S/N");
// char opcao = char.Parse(Console.ReadLine());

// if (opcao == 's')
// {
//     goto inicioCadastro;
// }




// cadastrarPassagens(nomes, origens, destinos, 0);
// cadastrarPassagens(nomes, origens, destinos, 1);
// cadastrarPassagens(nomes, origens, destinos, 2);

// for (int i = 0; i < nomes.Length; i++)
// {
//     Console.WriteLine($"Nome: {nomes[i]}");
//     Console.WriteLine($"Origem: {origens[i]}");
//     Console.WriteLine();

// }


// static void cadastrarPassagens(string[] nm, string[] or, string[] dn, string dt, int pos)
// {
//     nm[pos] = "{nm}";
//     or[pos] = "{or}";
//     dn[pos] = "{dn}";
// }




// string[] origem = new string[5];
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"informe seu pais de origem: ");
//     string origens = Console.ReadLine();

// }


// string[] destino = new string[5];
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"informe seu destino: ");
//     string destinos = Console.ReadLine();

// }

// DateOnly[] data = new DateOnly[5];
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"informe a data: ");
//     DateOnly datas = DateOnly.Parse(Console.ReadLine());

// }












