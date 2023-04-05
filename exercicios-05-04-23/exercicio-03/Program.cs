
bool salarioReal = false;

do {
    Console.WriteLine($"informe seu salario");
   float salario = float.Parse(Console.ReadLine());
   
    if (salario > 0)
    {
        salarioReal = true;
    }
    else 
    {
        Console.WriteLine($"salario invalido digite novamente");
        
    }
}
while (salarioReal == false);