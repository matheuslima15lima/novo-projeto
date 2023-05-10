// crie uma classe produto
// com as propriedades : int codigo, string Nome , Float preco
// crie um construtor vazio
// crie um construtor completo
using ListasObjetos;
//criar a lista de objetos(produtos) 
List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(2563,"camiseta QuickSilver",19.90f)
);

produtos.Add(
new Produto(1025,"Air jordan",400f)
);

Produto calcaDiesel = new Produto(1526,"calca diesel",15f);

produtos.Add(calcaDiesel);

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, {item.Preco:C}");
    
}

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index,produtoBuscado);

Console.WriteLine($"lista atualizada");
Console.WriteLine($"***************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} {produtos.IndexOf(item)}");
    
}



