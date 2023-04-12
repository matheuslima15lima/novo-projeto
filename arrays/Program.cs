// string [] carros = new string[3];
// Console.WriteLine($"digite o nome do seu carro");
// carros[0] = Console.ReadLine();
// Console.WriteLine($"digite o nome do seu carro");
// carros[1] = Console.ReadLine();
// Console.WriteLine($"digite o nome do seu carro");
// carros[2] = Console.ReadLine();

// Console.WriteLine($"primeiro carro da lista : {carros[0]}");
// Console.WriteLine($"segundo carro da lista : {carros[1]}");
// Console.WriteLine($"terceiro carro da lista : {carros[2]}");

// string[]carros = new string[3];

// for (int i = 0; i < 3; i++)
// {
//     // bloco de codigo a ser executado
//     Console.WriteLine($"digite o nome do {i + 1}º carro:");
//     carros[i] = Console.ReadLine();

// }
// for (int i = 0; i < 300; i++)
// {
//     Console.WriteLine($"o  {i + 1}º carro e: {carros [i]}");

// }
// foreach (var item in carros)
// {
//     Console.WriteLine($"Nome do carro: {item}");

// }




// pedir o numero
// criar o calculo
// dizer o dobro





// int[]numeros = new int[5];
// for (var i = 0; i < 5; i++)
// {
//     Console.WriteLine($"digite o nome do {i + 1}º numero:");
//     numeros[i] = int.Parse(Console.ReadLine());


// }

// foreach (int numero in numeros)
// {
//     Console.WriteLine($"o dobro de {numero} e:  {numero*2}");

// }

// receba o nome e idade de 5 pessoas

// string[] nomes = new string[3];
// for (var i = 0; i < 3; i++)
// {
//     Console.WriteLine($"digite seu nome");
//     nomes[i] = Console.ReadLine();




// }

// int[] idades = new int[3];
// for (var i = 0; i < 3; i++)
// {
//     Console.WriteLine($"digite sua idade");
//     idades[i] = int.Parse(Console.ReadLine());

// }




// foreach (var nome in nomes)
// {
//     Console.WriteLine($"nome: {nome}");

// }
// foreach (var idade in idades)
// {
//     Console.WriteLine($"idade: {idade} anos");
// }



// Console.WriteLine($"idade: {idade} anos");




//declarando as variaveis
string[] nomes = new string[5];
int[] idades = new int[5];

// recebe o nome das listas(arrays)
for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"informe o {i+1}º nome");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"informe a {i+1}º idade");
    idades[i] = int.Parse(Console.ReadLine());

}

for (var i = 0; i < 5; i++)
{
    // imprimir o nome
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($" {i+1}) nome: {nomes[i]}");
    Console.ResetColor();

    // imprimir a idade
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"idade: {idades[i]} anos");
    Console.ResetColor();
}

