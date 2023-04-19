// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu

static bool promocao(float desconto)
{

    if (desconto == 's')
    {
        return true;
    }
    else if (desconto == 'n')
    {
        return false;

    }
    else
    {
        Console.WriteLine($"opcao incorreta");
        return false;
    }

}

bool[] temDesconto = new bool[10];
string[] nomes = new string[10];
float[] precos = new float[10];
// bool[] temDesconto = {true, false};
// string[] nomes = {" pizza", " Coca"};
// float[] precos = {30.97f, 6};
string opcao;
do
{

    //criar menu de opcoes
    Console.WriteLine($"menu de opcoes");
    Console.WriteLine($@"
    selecione uma das opcoes
    [1] - CadastrarProduto
    [2] - ListarProdutos
    [0] - MostrarMenu
    ");

     opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"informe o produto");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"informe o preco");
                precos[i] = float.Parse(Console.ReadLine());

                Console.WriteLine($"este produto esta em promocao? s/n");
                char desconto = char.Parse(Console.ReadLine().ToLower());

                temDesconto[i] = promocao(desconto);

                if (temDesconto[i] == true)
                {
                    Console.WriteLine($"tem desconto");
                }
                else 
                {
                  
                    Console.WriteLine($"sem desconto");
                }
            }

            break;
        case "2":
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($@"
                nome= {nomes[i]}
                preco= {precos[i]}
                desconto = {temDesconto[i]}
                ");

                if (temDesconto[i] == true)
                {
                    Console.WriteLine($"desconto = SIM");
                    
                }
                else
                {
                    Console.WriteLine($"desconto = NAO");
                }
            }

            

            break;
        case "0":
            Console.WriteLine($"fim do programa");
            break;
        default:
            Console.WriteLine($"opcao invalida");
            break;
    }

} while (opcao != "0");