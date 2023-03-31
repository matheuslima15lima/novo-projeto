Console.WriteLine($"informe sua media");
float media = float.Parse(Console.ReadLine());

Console.WriteLine($"informe sua frequencia");
int frequencia = int.Parse(Console.ReadLine());

if ((media >= 7.0) && (frequencia >= 75))
{
    Console.WriteLine($"aluno aprovado");

}

else if ((media >= 3 && media <= 7) && (frequencia >= 75))
{
    Console.WriteLine($"avaliação de recuperação");

}
else
{
    Console.WriteLine($"reprovado");

}