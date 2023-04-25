using Poo_Tarde;

personagem p1 = new personagem();

Console.WriteLine($"informe o nome do personagem");
p1.nome = Console.ReadLine();

Console.WriteLine($"informe a idade do personagem");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"informe a armadura do personagem");
p1.armadura = Console.ReadLine();

Console.WriteLine($"informe a IA do personagem");
p1.ia = Console.ReadLine();

Console.WriteLine(@$"

{p1.nome}
{p1.idade}
{p1.armadura}
{p1.ia}


");





