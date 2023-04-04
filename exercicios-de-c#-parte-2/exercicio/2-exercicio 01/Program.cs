Console.WriteLine($"escreva o seu dia de nascimento");
 int dia = int.Parse(Console.ReadLine());


Console.WriteLine($"escreva o seu mes de nascimento");
int mes = int.Parse(Console.ReadLine());


Console.WriteLine($"escreva o seu ano de nascimento");
int ano = int.Parse(Console.ReadLine());

if (dia > 31)
{
    Console.WriteLine($"erro data falsa");
    
}

else if ( dia < 1)
{
    Console.WriteLine($"erro data falsa");
    
}
if(mes > 12 )
{
    Console.WriteLine($"erro data falsa");
    
}

if (ano > 2013)
{
    Console.WriteLine($"erro data falsa");
    
}

if (dia <= 31 && mes <= 12 && ano <= 2013)
{
 Console.WriteLine($"data cadastrada!");
    
}

