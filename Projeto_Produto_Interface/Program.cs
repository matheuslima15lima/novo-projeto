// intancia do objeto carrinho

using Projeto_Produto_Interface;

Carrinho carrinho = new Carrinho();
// instanciar objetos da classe produto
Produto p1 = new Produto(1, "GTA 5", 52.90f);
Produto p2 = new Produto(2, "Red Dead Redemption 2", 180f);
Produto p3 = new Produto(3, "Mortal Kombat X", 50.87f);


carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();
carrinho.TotalCarrinho();


Console.WriteLine($"após a remoçao");

carrinho.Remover(p2);
carrinho.Remover(p3);
carrinho.Listar();
carrinho.TotalCarrinho();


Console.WriteLine($"agora atualizado");

// criar um objeto com os dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "FiFa";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();

