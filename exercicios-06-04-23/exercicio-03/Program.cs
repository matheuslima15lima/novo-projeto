Console.WriteLine($"qual tabuada voce quer saber?");
int tabuada = int.Parse(Console.ReadLine());

for(int i =0 ; i <=10; i ++)
{
    Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
    
}