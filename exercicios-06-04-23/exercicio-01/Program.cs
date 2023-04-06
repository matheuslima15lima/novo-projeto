Console.WriteLine($"mande uma nota");
int nota = int.Parse(Console.ReadLine());



while (nota > 10 )
{
    Console.WriteLine($"ERRO DIGITE NOVAMENTE");
     nota = int.Parse(Console.ReadLine());
    
}
