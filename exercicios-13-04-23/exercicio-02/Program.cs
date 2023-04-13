// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

// declarar variaveis

Console.WriteLine(@$"


// Álcool 4,90:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro


// Gasolina 5,30:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro


");

// char combustivel;


Console.WriteLine($"escolha entre alcool ou gasolina A/G");
char combustível = char.Parse(Console.ReadLine());

Console.WriteLine($"quantos litros deseja?");
int litros = int.Parse(Console.ReadLine());

if (combustível == 'a' )
{

if (litros <= 20)
{
    Console.WriteLine($"voce pagara {4.90 * litros * (1)- 0.03}");
    
}

else if (litros > 20)
{
    Console.WriteLine($"voce pagara {4.90 * litros * (1)- 0.05}");
    
}
}


// gasolina

if (combustível == 'G')
{

    if (litros <= 20)
{
    Console.WriteLine($"voce pagara {5.30 * litros * (1)- 0.04}");
    
}

else if (litros > 20)
{
    Console.WriteLine($"voce pagara {5.30 * litros * (1)- 0.06}");
    
}
}
