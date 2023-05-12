//programa IMC
//Faça um programa que calcule o imc de uma pessoa recebendo os dados
//no console,ao final imprima o resultado no console

Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$" 
-----------------
| programa para |
| calcular imc  |
-----------------

");
Console.ResetColor();




Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"informe o peso atual do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / ((float)Math.Pow(altura,2));

Console.ForegroundColor = ConsoleColor.Magenta;
//concatenacao
Console.WriteLine("O paciente " + nome + " tem o imc igual a : " + imc );
Console.ResetColor();


//  //interpolacao
//  Console.WriteLine($"O paciente (nome) tem o imc igual a (imc)");
 










