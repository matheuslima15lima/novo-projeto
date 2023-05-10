//criar um projeto de console
//criar uma classe carro
//-marca
//-cor
//criar um construtor vazio e um completo
//receber dados no console para 
//adicionar 2 objetos em uma lista 
//exibir os dois objetos da lista no console
using projeto_carro;


List<Carro> carros = new List<Carro>();
carros.Add(
    new Carro("BMW", "azul")
);

carros.Add(
    new Carro("Ferrari", "vermelho")
);

carros.Add(
    new Carro("porsche", "branco")
);

carros.Add(
    new Carro("mustang", "preto")
);

foreach (var item in carros)
{
    Console.WriteLine($@"Carro: {item.Marca}
Cor: {item.Cor}
     ***************
     ");

}