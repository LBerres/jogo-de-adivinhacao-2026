using System.Security.Cryptography;

/*
v1

Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

Input (Entrada de Dados)O usuário digita número inteiro

Processamento
O sistema compara o número digitado com um número inteiro aleatório

Output (Saída de Dados)
O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"
*/

// 1. Nosso Jogo Deve Aceitar o input do Jogador e Exibir o Valor Digitado. - OK
// 2. Nosso Jogo Deve Gerar um Número Secreto Aleatório. - OK
// 3. Nosso Jogo Deve Comparar o Número Digitado com o Número Secreto e Exibir Uma Mensagem de Feedback. - OK
<<<<<<< HEAD
// 4. Nosso Jogo Deve Permitir Multiplas Tentativas Para o Jogador Adivinhar o Número Secreto. - OK
=======
// 4. Nosso Jogo Deve Permitir Multiplas Tentativas Para o Jogador Adivinhar o Número Secreto. - 
>>>>>>> ced09341908748304af9651d6f0c1428a3a6a95f

// 1 - 20 (numero Mínimo, numero Máximo (exclusivo))
int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
bool jogoDeveContinuar = true;

while (jogoDeveContinuar)
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("----------------------------------------------");

    Console.WriteLine();
    Console.Write("Digite um Número: ");
    string strNumeroDigitado = Console.ReadLine();
    int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

    if (numeroAleatorio == numeroDigitado)
    {
        Console.WriteLine("Parabéns, Você Acertou! O Número Secreto era: " + numeroAleatorio);
    }
    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("Dica: O Número Digitado é Maior do que o Número Secreto.");
    }
    else
    {
        Console.WriteLine("Dica: O Número Digitado é Menor do que o Número Secreto.");
    }

    Console.WriteLine();
    Console.WriteLine("Deseja Jogar Novamente? (S/N)");
<<<<<<< HEAD

=======
    
>>>>>>> ced09341908748304af9651d6f0c1428a3a6a95f
    string resposta = Console.ReadLine();

    if (resposta != "S" && resposta != "s")
    {
        jogoDeveContinuar = false;
        Console.WriteLine("Obrigado por Jogar! Até a Próxima!");
        Console.WriteLine("----------------------------------------------");
        Console.ReadLine();
    }
}
