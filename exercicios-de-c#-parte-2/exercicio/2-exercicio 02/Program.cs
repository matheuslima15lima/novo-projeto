Console.WriteLine($"escreva os numeros");
 int numero1 = int.Parse(Console.ReadLine()) ;

 int numero2 = int.Parse(Console.ReadLine()) ;

 int numero3 = int.Parse(Console.ReadLine()) ;

 if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine($"numero1 maior");
    
}
if (numero2 > numero1 && numero2 == numero3)
{
    Console.WriteLine($"numero2 e numero3 maiores");
    
}
if (numero2 > numero1 && numero2 > numero3);
{
    Console.WriteLine($"numero 2 maior");
    
}
if (numero2 > numero3 && numero2 == numero1)
{
    Console.WriteLine($"numero2 e numero1 maiores");
    

}


else if (numero1 == numero2 && numero1 == numero3)
{ 
    Console.WriteLine($"todos iguais");
    
}