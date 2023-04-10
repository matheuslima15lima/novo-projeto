// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

char sexo;
int totalHomem = 0;
int totalMulher = 0;
float mediaIdadeMulher = 0;
float mediaIdadeHomem = 0;
int idadeMulher = 0;
int IdadeHomem = 0;



for (var i = 1; i <=10; i++)
{
  Console.WriteLine(@$"
    informe o sexo da pessoa:
    (m) - Masculino
    (f) - Feminino
    ");

    sexo = char.Parse(Console.ReadLine());

    if (sexo == 'f')
    {
        totalMulher++;
    }
    
    if (sexo == 'm')
    {
        totalHomem++;

        Console.WriteLine($"informe a idade");
        IdadeHomem = int.Parse(Console.ReadLine());
        
    }
    // Console.WriteLine($"informe o peso");
    // float.Parse(Console.ReadLine());

    
    

}
mediaIdadeHomem = (IdadeHomem++ /IdadeHomem++);
   
//     porcentagemHomemNao = ((float)totalHomemNao/(float)totalHomem)*100;
// Console.WriteLine($"A porcentagem de homens que responderam que nao gostaram e de: {porcentagemHomemNao} %");


    
    

