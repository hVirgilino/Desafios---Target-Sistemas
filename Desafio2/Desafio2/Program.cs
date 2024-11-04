/* Target Sistemas - Desafio 2
 * 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
*/

Console.WriteLine("Digite o número para saber se ele está presente na sequência de Fibonacci: ");

try
{
    int numFibonacci = int.Parse(Console.ReadLine());

    if (numFibonacci < 0)
    {
        Console.WriteLine("Deve ser um número inteiro e positivo.");
        return -1;
    }

    int a = 0;
    int b = 1;
    int posicao = 1;
    bool estaNaSeq = false;

    List<int> seqFibonacci = new List<int>();
    List<int> posicoes = new List<int>();

    do
    {
        seqFibonacci.Add(a);
        posicoes.Add(posicao);

        
        if (a == numFibonacci)
        {
            estaNaSeq = true;
            break;
        }

        
        int temp = a;
        a = b;
        b = temp + b;
        posicao++;

    } while (a <= numFibonacci);

    if (estaNaSeq)
    {
        Console.WriteLine($"O número {numFibonacci} está na sequência de Fibonacci na posição {posicao}.");

        foreach (int valor in seqFibonacci)
        {
            Console.Write(valor + " ");
        }
        Console.Write("\n");

        foreach (int pos in posicoes)
        {
            Console.Write(pos + " ");
        }
    }
    else
    {
        Console.WriteLine($"O número {numFibonacci} não está na sequência de Fibonacci.");
    }

    return 0;
}
catch (FormatException)
{
    Console.WriteLine("Deve ser um número.");
    return -1;
}
    
    
