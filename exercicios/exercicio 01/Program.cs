Console.WriteLine($"informe o salario");
float salario = float.Parse (Console.ReadLine());

Console.WriteLine($"informe total gasto");
float totalGasto = float.Parse (Console.ReadLine());





if (totalGasto > salario)
{
    Console.WriteLine($"orçamento estourado");
}
else
{
    Console.WriteLine($"gastos dentro do orçamento");
}