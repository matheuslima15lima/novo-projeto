// //variaveis

// //declarando variavel
// //tipo nome = valor
// string nome = "Matheus";
// const int idade = 15;
// Console.WriteLine("a idade do " + nome + " e " + idade + " anos");
 
//tipos de dados
// int quantidade = 10;
// double preço = 4.99d;
// float altura = 1.80f;
// bool careca = true;
// string texto = "Ola mundo";
// char letra = 'C';

// //operador de atribuição
// int idade = 36;

// operadores aritmeticos

// //soma
// Console.WriteLine(4 + 4);


// // subtracao
// Console.WriteLine(10 - 8);


// // modulo
// Console.WriteLine(5 % 2);


//igual a
// Console.WriteLine(5 == 6);


// Maior ou igual a 


//  Menor ou igual a

//operadores logicos e tabela verdade

//&& : e
//|| : ou
// ! : negacao
// Console.WriteLine(5 == 5 && 8 == 8);
// Console.WriteLine(5 == 5 && 8 == 9);
// Console.WriteLine(5 == 6 && 8 == 8);

// Console.WriteLine(2 == 2 || 3 == 4);
// Console.WriteLine(2 == 1 || 3 == 4);
// Console.WriteLine(!(2 == 4 || 3 == 8));

//crie um programa para calcular o imc de uma pessoa

//entradas
string nome = "Matheus";
float peso = 58.8f;
float altura = 1.75f;

//processamento
float imc = peso / (altura * altura);
Console.WriteLine("O IMC do " + nome + " e de : " + Math.Round (imc,2));




