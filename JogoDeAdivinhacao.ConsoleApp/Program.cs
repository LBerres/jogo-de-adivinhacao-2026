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

2. Implemente uma funcionalidade de Validação de Números Repetidos - OK
    O jogador deve ser informado caso o número que está tentando adivinhar já tenha sido informado anteriormente na mesma rodada.

3. Implemente uma funcionalidade de Pontuação, onde: - OK
    O jogador começa com uma pontuação máxima, por exemplo, 1000 pontos.
    A pontuação é calculada com base na proximidade do palpite em relação ao número secreto.
    A cada tentativa errada, o jogador perde pontos de acordo com a distância do número secreto:
    Se a diferença entre o número secreto e o palpite for de 10 ou mais, o jogador perde 100 pontos.
    Se a diferença for entre 5 e 9, o jogador perde 50 pontos.
    Se a diferença for entre 1 e 4, o jogador perde 20 pontos.
    Quando o jogador acerta o número, sua pontuação final é registrada.
*/
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
    int pontuacao = 1000; // Variável para Armazenar a Pontuação do Jogador
    int[] numerosDigitados = new int[tentativasMaximas]; // Array para Armazenar os Números Digitados
    int contadorNumerosDigitados = 0; // Contador para Controlar a Quantidade de Números Digitados

    // Enquanto a Tentativa Atual For Menor que a Quantidade Máxima de Tentativas, o Jogo Continua
    for (int tentativaAtual = 1; tentativaAtual <= tentativasMaximas; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativasMaximas}");
        Console.WriteLine("Pontuação Atual: " + pontuacao);
        Console.WriteLine("----------------------------------------------");

        Console.Write("Digite um Número: ");
        string strNumeroDigitado = Console.ReadLine();
        int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

        //Comparar o Número Digitado com os Números Anteriores
        bool numeroRepetido = false;

        for (int indiceatual = 0; indiceatual < numerosDigitados.Length; indiceatual++)
        {
            if (numerosDigitados[indiceatual] == numeroDigitado)
            {
                numeroRepetido = true;
                break; // Sair do Loop se Encontrar um Número Repetido
            }
        }

        if (numeroRepetido == true)
        {
            Console.WriteLine("Você Já Digitou Esse Número Anteriormente! Tente um Número Diferente.");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Digite Enter Para Continuar...");
            Console.ReadLine();

            tentativaAtual--; // Decrementar a Tentativa Atual para Não Contar a Tentativa Repetida
            continue;
        }

        //Guardar o Número na Memória
        if (contadorNumerosDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorNumerosDigitados] = numeroDigitado;
            contadorNumerosDigitados++;
        }
        else
        {
            numerosDigitados = new int[tentativasMaximas];
            contadorNumerosDigitados = 0;

            numerosDigitados[contadorNumerosDigitados] = numeroDigitado;
            contadorNumerosDigitados++;
        }

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

        int diferencaNumerica = Math.Abs(numeroAleatorio - numeroDigitado);

        if (diferencaNumerica >= 10)
        {
            pontuacao -= 100;
        }
        else if (diferencaNumerica >= 5)
        {
            pontuacao -= 50;
        }
        else
        {
            pontuacao -= 20;
        }
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Pontuação Atual: " + pontuacao);
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
