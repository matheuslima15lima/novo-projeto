// //calculadora

// //Algoritmo

// //1. informar a operacao 
// //2. informar o primeiro numero
// //3. informar o segundo numero
// //4. processar os dados
// //5. exibir o resultado


// //entrada 

// Console.WriteLine(@$"
// -------------------------------------
// | Programa de calculadora |   
// |                                          | 
// |   Informe a operação        |
// |                                          |
// |    (+) soma                        |
// |    (-) subtração                  |
// |    (*) multiplicação             |
// |    (/) divisão                       |
// --------------------------------------
// ");

// char operacao = char.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o primeiro número: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// double num2 = double.Parse(Console.ReadLine());

// double resultado = 0;

// //processamento
// //saida

// switch (operacao)
// {
//     case '+':
//         resultado = (num1 + num2);
//         Console.WriteLine($"O resultado da conta é igual á : {resultado}");
//         break;
//     case '-':
//         resultado = (num1 - num2);
//         Console.WriteLine($"O resultado da conta é igual á : {resultado}");
//         break;
//     case '*':
//         resultado = (num1 * num2);
//         Console.WriteLine($"O resultado da conta é igual á : {resultado}");
//         break;
//     case '/':
//         resultado = (num1 / num2);
//         Console.WriteLine($"O resultado da conta é igual á : {resultado}");
//         break;
//     default:
//         Console.WriteLine($"Operação inválida, repita o processo!");        
//         break;
//  }





//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional



Console.WriteLine(@$"Text
--------------------------
|                        |
|   escolha sua bebida   |
|                        |
|     (1) coca-cola      |                   
|     (2)pepsi           |
|     (3) fanta          |                 
|     (4) suco del valle | 
|                        |
--------------------------

");
//armazena a opcao escolhida
char bebida = char.Parse(Console.ReadLine());

//processamento
switch (bebida)
{
    case '1':

        Console.WriteLine($"quer gelo? s/n");
        char resposta = char.Parse(Console.ReadLine().ToLower());

        if (resposta == 's')
        {
            Console.WriteLine($"a bebida vir'a com adicional de gelo");
        }
        else if (resposta == 'n')
        {
            Console.WriteLine($"nao vir'a com gelo");
        }
        else
        {
            Console.WriteLine($"opcao invalida");

        }

        break;

    case '2':
        Console.WriteLine($"quer adicionar gelo? s/n");
        char resposta2 = char.Parse(Console.ReadLine().ToLower());

        if (resposta2 == 's')
        {
            Console.WriteLine($"a bebida vir'a com adicional de gelo");
        }
        else if (resposta2 == 'n')
        {
            Console.WriteLine($"nao vir'a com gelo");
        }

        else
        {
            Console.WriteLine($"opcao invalida");

        }
        break;

    case '3':
        Console.WriteLine($"quer adicionar gelo? s/n");
        char resposta3 = char.Parse(Console.ReadLine().ToLower());
        if (resposta3 == 's')
        {
            Console.WriteLine($"a bebida vir'a com adicional de gelo");
        }
        else if (resposta3 == 'n')
        {
            Console.WriteLine($"nao vir'a com gelo");
        }
        else
        {
            Console.WriteLine($"resposta invalida");

        }
        break;

    case '4':
        Console.WriteLine($"quer adicionar gelo? s/n");
        char resposta4 = char.Parse(Console.ReadLine().ToLower());
        if (resposta4 == 's')
        {
            Console.WriteLine($"a bebida vir'a com adicional de gelo");
        }
        else if (resposta4 == 'n')
        {
            Console.WriteLine($"nao vir'a com gelo");
        }
        else
        {
            Console.WriteLine($"resposta invalida");


        }
        break;
}

    




//         Console.WriteLine($"deseja adicionar gelo na bebida?");
//     case 's':
//         Console.WriteLine($"agradecemos ao seu pedido!");
//         break;

//     case 'n':
//         Console.WriteLine($"agradecemos ao seu pedido!");
//         break;

//     default:
//     Console.WriteLine($"erro , digite novamente!!!");

//         break;
// }



// else
// {
//     Console.WriteLine($"erro, essa opção não esta disponivel");    
// }




