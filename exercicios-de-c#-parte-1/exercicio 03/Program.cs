Console.WriteLine($"informe os lados do triangulo");
int lado = int.Parse(Console.ReadLine());
int lado2 = int.Parse(Console.ReadLine());
int lado3 = int.Parse(Console.ReadLine());

if ((lado == lado2) && (lado == lado3))
{
    Console.WriteLine($"equilatero");

}

else if ((lado != lado2) && (lado == lado3) || (lado == lado2) && (lado != lado3) || (lado2 == lado3) && (lado2 != lado))
{
    Console.WriteLine($"isoceles");

}

else
{
    Console.WriteLine($"escaleno");


}
