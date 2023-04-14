//3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%


Console.WriteLine($"Informe o produto: ");
string produto = Console.ReadLine();


Console.WriteLine($"informe a quantidade de produtos");
int quantidade = int.Parse(Console.ReadLine());

if (quantidade >= 5)
{
    Console.WriteLine($"voce pagara {5.50f * quantidade * (1)- 0.02f}");
    
}

else if (quantidade < 5)
{
    Console.WriteLine($"preco: {5.50f* quantidade}");
    
}


else if (quantidade == 10)
{
  Console.WriteLine($"voce pagara {5.50f * quantidade * (1) - 0.05f}");
  
}

// if (quantidade == 5)
// {
//     Console.WriteLine($"voce pagara {6.00f * quantidade * (1)- 0.02}");
    
// }

// else if (quantidade < 5)
// {
//     Console.WriteLine($"preco: {6.00* quantidade}");
    
// }

// else if (quantidade == 10)
// {
//   Console.WriteLine($"voce pagara {6.00 * quantidade * (1)- 0.05}");
  
// }

//  if (quantidade == 5)
// {
//     Console.WriteLine($"voce pagara {7.00 * quantidade * (1)- 0.02}");
    
// }

// else if (quantidade < 5)
// {
//     Console.WriteLine($"preco: {7.00* quantidade}");
    
// }


// else if (quantidade == 10)
// {
// //   Console.WriteLine($"voce pagara {7.00 * quantidade * (1)- 0.05}");
  
// }






// int []numeros = new int[] {999,2,1,458,54};
                            //0   1 2 3    4