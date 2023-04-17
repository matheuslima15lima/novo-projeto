// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

//declarando um array
string[] nomes = new string[3];


bool nomeEncontrado = false;

for (var i = 0; i < nomes.Length; i++)
{
       Console.WriteLine($"informe o {i+1}º nome");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine($"informe o nome a ser buscado: ");
string nomeBuscado = Console.ReadLine();

// processamento
foreach ( string nome  in nomes)
{
    if (nome == nomeBuscado)
    {
        nomeEncontrado = true;
        break;
    }
}

// saida - exibir

if (nomeEncontrado == true)
{
    Console.WriteLine($"ACHEI");
    
}

else
{
    Console.WriteLine($"NAO ACHEI");
    
}

string resultadoBusca = nomeEncontrado == true ? "Achei" : "NÃO ACHEI";

Console.WriteLine(nomeEncontrado ? "Achei" : "nao achei");
