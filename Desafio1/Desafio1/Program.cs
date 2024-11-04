/* Target Sistemas - Desafio 1
1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?
*/

int INDICE = 13, SOMA = 0, K = 0; // Declaração das variáveis

while (K < INDICE) // Loop
{
    K += 1; // K = K + 1
    SOMA += 1;// SOMA = SOMA + 1
}

Console.WriteLine(SOMA); // 13
