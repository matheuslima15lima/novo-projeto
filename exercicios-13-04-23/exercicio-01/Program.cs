int AnoAtual = 2023;



Console.WriteLine($"digite o ano que vc nasceu");
int AnoDenasc =  int.Parse(Console.ReadLine());
int IdadepraVoto = AnoAtual - AnoDenasc;

if (IdadepraVoto >= 18)
{
 Console.WriteLine($"pode votar meu bom!");
 
}



else if (IdadepraVoto >= 16)
{
    Console.WriteLine($"voto opcional meu jovem");
    
}

else
{
    Console.WriteLine($"nao pode votar ainda");
    
}

// else 
// {
//     Console.WriteLine($"voto opicional");
    
// }

