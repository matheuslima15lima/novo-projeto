Console.WriteLine($"digite seu nome");
string nome = Console.ReadLine();

Console.WriteLine($"digite sua senha");
string senha = Console.ReadLine();

while (nome == senha)
{
    Console.WriteLine($"erro digite novamente");
    nome = Console.ReadLine();
    senha = Console.ReadLine();
   
   if (nome != senha)
   {
    Console.WriteLine($"aprovado");
    

   }

}