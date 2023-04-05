bool estadoCivil =false;
do 
{
Console.WriteLine(@$"
informe seu estado civil 

S= solteiro
C= casado
v = viuvo
D = divorciado
");


char estado = char.Parse(Console.ReadLine());

if ((estado == 'C') || (estado == 'D') || (estado == 'S') || (estado == 'V'))
{
    estadoCivil= true;
Console.WriteLine($"cadastrado");



}

else 

Console.WriteLine($"invalido");

}
while (estadoCivil = false);

    



