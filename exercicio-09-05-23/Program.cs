// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

using System.Globalization;
using exercicio_09_05_23;


menu:
Console.WriteLine($@"

Escollha a opcao:
[1] Dolar para Real
[2] Real para Dolar
[0]sair


");
// do
// {
char escolha = char.Parse(Console.ReadLine()!);


    

switch (escolha)
{
    
    case '1':
        Console.WriteLine($"qual valor deseja");
        float moeda1 = float.Parse(Console.ReadLine()!);

        float valor1 = ConversorMoedas.DolarParaReal(moeda1);
        Console.WriteLine($"{valor1:C}");

        goto menu;
        break;

       
    case '2':

        Console.WriteLine($"qual valor deseja?");
        float moeda = float.Parse(Console.ReadLine()!);

        float valor2 = ConversorMoedas.RealParaDolar(moeda);
        Console.WriteLine($"{valor2.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

        goto menu;
        break;

        case '0':
        Console.WriteLine($"tchau!!!");
        
        break;

    default:
    Console.WriteLine($"erro opcao invalida!!!");
    
        break;
}
// } while (escolha != '0');














