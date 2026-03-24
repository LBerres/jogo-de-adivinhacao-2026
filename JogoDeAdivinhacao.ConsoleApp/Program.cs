using System.Security.Cryptography;

/*
v1

Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

Input (Entrada de Dados)O usuário digita número inteiro

Processamento
O sistema compara o número digitado com um número inteiro aleatório

Output (Saída de Dados)
O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"

v2

1. Implemente a funcionalidade de Dificuldade e Tentativas limitadas - OK

    O jogador tem um número limitado de tentativas para adivinhar o número.
        Fácil (intervalo 1 a 20): ≈ 10 tentativas.
        Médio (intervalo 1 a 50): ≈ 5 tentativas.
        Difícil (intervalo 1 a 100): ≈ 3 tentativas.
*/



// 1 - 20 (numero Mínimo, numero Máximo (exclusivo))

bool jogoDeveContinuar = true;

while (jogoDeveContinuar)
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Escolha Um Nivél de Dificuldade:");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("1 - Fácil (10 Tentativas)");
    Console.WriteLine("2 - Médio (5 Tentativas)");
    Console.WriteLine("3 - Difícil (3 Tentativas)");
    Console.WriteLine("----------------------------------------------");

    Console.Write("Digite a Sua Escolha: ");
    string strDificuldadeEscolhida = Console.ReadLine();

    int numeroAleatorio;
    int tentativasMaximas;

    switch (strDificuldadeEscolhida) // Operador de Seleção Múltipla (Switch Case)
    {

        case "1": // O : Serve para Indicar o Início do Bloco de Código do Case
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativasMaximas = 10;
            break; // Sempre Usar o Break para Sair do Case
        case "2":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativasMaximas = 5;
            break;
        case "3":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativasMaximas = 3;
            break;
        default:
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Por Favor, Digite Uma Opção Válida!");
            Console.Write("Digite Enter Para Continuar...");
            Console.ReadLine();
            continue; // Volta para o Início do Loop

    }

    // Enquanto a Tentativa Atual For Menor que a Quantidade Máxima de Tentativas, o Jogo Continua
    for (int tentativaAtual = 1; tentativaAtual <= tentativasMaximas; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativasMaximas}");
        Console.WriteLine("----------------------------------------------");
        Console.Write("Digite um Número: ");
        string strNumeroDigitado = Console.ReadLine();
        int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

        if (numeroAleatorio == numeroDigitado)
        {
            Console.WriteLine("Parabéns, Você Acertou! O Número Secreto era: " + numeroAleatorio);
            break;
        }
        else if (numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("Dica: O Número Digitado é Maior do que o Número Secreto.");
        }
        else
        {
            Console.WriteLine("Dica: O Número Digitado é Menor do que o Número Secreto.");
        }

        Console.WriteLine("----------------------------------------------");
        Console.Write("Digite Enter Para Continuar...");
        Console.ReadLine();
    }

    Console.WriteLine();
    Console.WriteLine("Deseja Jogar Novamente? (S/N)");

    string resposta = Console.ReadLine();

    if (resposta != "S" && resposta != "s")
    {
        jogoDeveContinuar = false;
        Console.WriteLine("Obrigado por Jogar! Até a Próxima!");
        Console.WriteLine("----------------------------------------------");
        Console.ReadLine();
    }
}
