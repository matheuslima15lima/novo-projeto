
using calculadora_24_04_23;


Calculadora calc = new Calculadora();
Console.WriteLine($"informe o primeiro numero");
calc.numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe o segundo numero");
float n2 = float.Parse(Console.ReadLine());

// preencher as propriedades de classe
calc.numero2 = n2;



string op = Console.ReadLine().ToLower();

calculadora c1 = new calculadora();

Console.WriteLine($@"



+ somar
- subtrair
/ dividir
* multiplicar


");


switch (op)
{
   case "+":
      Console.WriteLine($"O resultado da soma é: {calc.Somar()}");
      break;
   case "-":
      Console.WriteLine($"O resultado da subtração é: {calc.Subtrair()}");
      break;
   case "*":
      Console.WriteLine($"O resultado da multiplicação é: {calc.Multiplicar()}");
      break;
   case "/":
      Console.WriteLine($"O resultado da divisão é: {calc.Dividir()}");
      break;
   case "s":
      Console.WriteLine($"Programa finalizado com sucesso, volte sempre!");
      break;
   default:
   Console.WriteLine($"Opção Inválida");
   break;
}

