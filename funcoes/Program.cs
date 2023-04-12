

// int idadAluno  //camelCase

// static void SomarNotas//PascalCase


static float Soma(float n1, float n2){

    float r = n1 + n2;
    return r;
}
float resultsS = Soma(16, 123);

Console.WriteLine($"Resultado: {resultsS}");


// criar metodo para multiplicar 2 numeros
// criar metodo para dividir 2 numeros
// criar metodo para subtrair 2 numeros

static float Multiplicar (float n1, float n2){

    float r = n1 * n2;
    return r;
}
float resultsM = Multiplicar(5, 3);

Console.WriteLine($"Resultado: {resultsM}");


static float Dividir (float n1, float n2){
    float r = n1 / n2;
    return r;

}
float resultsD= Dividir(20, 4);
Console.WriteLine($"resultado: {resultsD}");


static float Subtrair (float n1, float n2){
    float s = n1 - n2;
    return s;
}


float resultsSU = Subtrair(40, 40);
Console.WriteLine($"resultado: {resultsSU}");


