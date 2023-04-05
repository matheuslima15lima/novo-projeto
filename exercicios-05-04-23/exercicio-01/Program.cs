bool nomeCerto = false;

while (nomeCerto == false)
{
    Console.WriteLine($"digite seu nome");
    string nome = Console.ReadLine();
    
    if (nome != "")
    {
        nomeCerto = true;
    }
}