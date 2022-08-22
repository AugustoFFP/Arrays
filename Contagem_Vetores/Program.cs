using System;

class program
{
    static void Main(string[] args)
    {
        int[] vetor = { 11, 15, 9, 12, 15, 32, 20, 15, 10 };
        int chave = 15;
        int soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] >= chave)
            {
                soma += vetor[i];

            }
        }
        Console.WriteLine(soma);
    }
}