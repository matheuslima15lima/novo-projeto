

// int idadAluno  //camelCase

// static void SomarNotas//PascalCase


// static float Soma(float n1, float n2){

//     float r = n1 + n2;
//     return r;
    
    
// }

// Console.WriteLine($"digite o 1º numero");
// float n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"digite o 2º numero");
// float n2 = float.Parse(Console.ReadLine());


// float resultsS = Soma(n1, n2);

// Console.WriteLine($"Resultado: {resultsS}");


// // criar metodo para multiplicar 2 numeros
// // criar metodo para dividir 2 numeros
// // criar metodo para subtrair 2 numeros

// static float Multiplicar (float n1, float n2){

//     float r = n1 * n2;
//     return r;
// }
// float resultsM = Multiplicar(5, 3);

// Console.WriteLine($"Resultado: {resultsM}");


// static float Dividir (float n1, float n2){
//     float r = n1 / n2;
//     return r;

// }
// float resultsD= Dividir(20, 4);
// Console.WriteLine($"resultado: {resultsD}");


// static float Subtrair (float n1, float n2){
//     float s = n1 - n2;
//     return s;
// }


// float resultsSU = Subtrair(40, 40);
// Console.WriteLine($"resultado: {resultsSU}");





// ************* exercicio de hoje************

//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda


static float leaoFaminto (float rendimento){

float r = rendimento;
return r;

}

Console.WriteLine($@"

--------------------------------------
tabela de imposto de renda           |
                                     |
ate r$1500- isento                   |
                                     |
de $1501 até $3500 - 20% de imposto  |
                                     |
de $3501 até $6000 - 25% de imposto  |
                                     |
acima de $6000 - 35% de imposto      |
--------------------------------------
");

Console.WriteLine($"informe seu rendimento");
float rendimento = float.Parse(Console.ReadLine());



if (rendimento <=1500)
{
    Console.WriteLine($"voce esta isento de imposto");
    
}


else if ((rendimento >= 1501) && (rendimento <=3500)) 
{
    Console.WriteLine($"voce vai pagar R${rendimento * 20/100}");
    
}
else if ((rendimento >= 3501) && (rendimento <=6000)) 
{
    Console.WriteLine($" voce vai pagar {rendimento * 70/100}");
    
}
else
{
    Console.WriteLine($" voce vai pagar {rendimento * 35/100}");
    
}



