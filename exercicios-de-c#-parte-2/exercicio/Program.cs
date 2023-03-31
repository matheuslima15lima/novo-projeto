int anoatual = 2013;

Console.WriteLine($"informe o ano que vc nasceu");
int anonascimento = int.Parse(Console.ReadLine());

Console.WriteLine($"informe o dia");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"informe o mes");
int mes = int.Parse(Console.ReadLine());


if ( anonascimento >=18)
{
     int idade = anonascimento - anoatual;
Console.WriteLine($"aprovado");
}


else
{
    Console.WriteLine($"idade reprovada");
    
}
