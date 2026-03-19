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

// 1. Nosso Jogo deve Aceitar o input do Jogador e Exibir o Valor Digitado. - OK
// 2. Nosso Jogo deve Gerar um Número Secreto Aleatório. - OK
// 3. Nosso Jogo deve Comparar o Número Digitado com o Número Secreto e Exibir Uma Mensagem de Feedback. - 
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("----------------------------------------------");

Console.WriteLine();
Console.Write("Digite um Número: ");
string strNumeroDigitado = Console.ReadLine();
int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

// 1 - 20 (numero Mínimo, numero Máximo (exclusivo))
int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

if (numeroAleatorio == numeroDigitado)
{
    Console.WriteLine("Parabéns, Você Acertou! O Número Secreto era: " + numeroAleatorio);
}
else if (numeroDigitado > numeroAleatorio)
{
    Console.WriteLine("Dica: O número digitado é maior do que o número secreto.");
}
else
{
    Console.WriteLine("Dica: O número digitado é menor do que o número secreto.");
}

Console.ReadLine();