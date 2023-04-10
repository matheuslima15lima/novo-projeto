// Console.WriteLine($"qual seu sexo? M/F");
// char resposta1 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta2 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta3 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta4 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta5 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta6 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta7 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta8 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta9 = char.Parse(Console.ReadLine());

// Console.WriteLine($"qual seu sexo? M/F");
// char resposta10 = char.Parse(Console.ReadLine());




// Console.WriteLine($"gostou do produto? S/N");
// char respostas1 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas2 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas3 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas4 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas5 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas6 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas7 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas8 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas9 = char.Parse(Console.ReadLine());

// Console.WriteLine($"gostou do produto? S/N");
// char respostas10 = char.Parse(Console.ReadLine());




char sexo;
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulher = 0;
int totalMulherSim = 0;

int totalHomem = 0;
int totalHomemNao = 0;

float porcentagemHomemNao = 0;


for (var i = 1; i <= 3; i++)
{
    // entrada de dados
    Console.WriteLine(@$"
    informe o sexo da pessoa:
    (m) - Masculino
    (f) - Feminino
    ");

    sexo = char.Parse(Console.ReadLine());
    
    


    // processamento
    if (sexo == 'f')
    {
        totalMulher++;
    }
    else
    {
        totalHomem++;
    }
    Console.WriteLine(@$"
    A pessoa gostou do lancamento?
     (s) - sim
     (n) - nao
    ");

    gostouDoProduto = char.Parse(Console.ReadLine());

    if (gostouDoProduto == 's')
    {
    totalSim ++;

    if (sexo == 'f')
    {
        totalMulherSim++;
    }

    }
    else
    {
        totalNao++;

        if (sexo == 'm')
        {
            totalHomemNao++;
        }
    }
    
    
}
porcentagemHomemNao = ((float)totalHomemNao/(float)totalHomem)*100;
Console.WriteLine($"A porcentagem de homens que responderam que nao gostaram e de: {porcentagemHomemNao} %");


// Console.WriteLine($"totalMulher");


