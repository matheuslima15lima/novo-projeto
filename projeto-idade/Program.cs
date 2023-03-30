
// Console.WriteLine($"Informe a sua idade: ");
// int idade = int.Parse(Console.ReadLine());

// int mes = idade * 12;
// int dias = idade * 365;
// int horas = dias * 24;
// int minutos = horas * 60;

// Console.WriteLine($"A idade em mes e : {mes}, em dias e igual a : {dias}, em horas igual a : {horas} e em minuto igual a {minutos}");




Console.WriteLine($"informe sua ano de nascimento");
int anoNascimento = int.Parse(Console.ReadLine());

int anoAtual = DateTime.Now.Year;

int idade = anoAtual - anoNascimento;

Console.WriteLine($"a idade e {idade} anos");





