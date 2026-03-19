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
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("----------------------------------------------");

Console.WriteLine();
Console.Write("Digite um Número: ");
string strNumeroDigitado = Console.ReadLine();

Console.WriteLine("O Número Digitado foi: " + strNumeroDigitado);