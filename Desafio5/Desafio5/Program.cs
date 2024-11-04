/*
 * 5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;
*/

try
{
    Console.Write("Digite uma string: ");
    string String = Console.ReadLine();

    string inverso = "";

    for (int i = String.Length - 1; i >= 0; i--)
    {
        inverso += String[i];
    }


    Console.WriteLine($"Inverso da string informada: {inverso}");
}
catch (Exception ex)
{
    Console.WriteLine($"Houve um erro ao informar a string: {ex.Message}");
}