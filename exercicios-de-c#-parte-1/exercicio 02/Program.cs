Console.WriteLine($"informe os gols do time1");
int time1 = int.Parse(Console.ReadLine());

Console.WriteLine($"informe os gols do time2");
int time2 = int.Parse(Console.ReadLine());

if (time1 > time2)
{
Console.WriteLine($"time1 ganhou");

}

else if (time1 < time2)
{
Console.WriteLine($"time2 ganhou");
}

else 
{
Console.WriteLine($"empate");
}






