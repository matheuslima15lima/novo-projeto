// Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.
int[] numeros = new int[15];
for (var i = 0; i < 15; i++)
{
    Console.WriteLine($"informe o {i+1}º numero");
    numeros[i] = int.Parse(Console.ReadLine());
    
}

foreach (var item in numeros.Reverse())
{
    Console.WriteLine($"ordem inversa: {item}");
    
}
