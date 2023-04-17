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



string senhaCorreta = "podeser";

Console.WriteLine($"digite a senha");
string senha = Console.ReadLine();



while (senha != "podeser")
{
    Console.WriteLine($"erro senha incorreta");

}








static string destiny(string destinos)
{
    string r = destinos;
    return r;
}



// criando os arrays
string[] nomes = new string[5];
string[] origens = new string[5];
string[] destinos = new string[5];
DateOnly[] datas = new DateOnly[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"informe seu nome ");
    string nm = Console.ReadLine();

    Console.WriteLine($"informe seu pais de origem: ");
    string or = Console.ReadLine();

    Console.WriteLine($"informe seu destino: ");
    string dn = Console.ReadLine();

    Console.WriteLine($"informe a data: ");
    DateOnly dt = DateOnly.Parse(Console.ReadLine());


    nomes[i] = nm;
    origens[i] = or;
    destinos[i] = dn;
    datas[i] = dt;

}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(@$"
    
    nome: nomes {i}
    
    
    
    
    ");
    
}



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












