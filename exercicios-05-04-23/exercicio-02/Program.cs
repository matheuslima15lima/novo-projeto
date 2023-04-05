


bool idadeCerta = false;
do{
    Console.WriteLine($"informe sua idade");
int idade = int.Parse(Console.ReadLine());
if (idade <= 100)
{
    idadeCerta = true;
}
else {
    Console.WriteLine($"idade invalida");
    
}
}

 while (idadeCerta == false);
 
 