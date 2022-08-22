using System;

class program
{
    static void Main(string[] args)
    {
        int[] vetor = { 11, 15, 9, 12, 9, 32, 20, 32, 10 };
        int maior = 0;
        int menor = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (i == 0)
            {
                maior = vetor[i];
                menor = vetor[i];
            }
            if (maior < vetor[i])
            {
                maior = vetor[i];
            }

            if(menor > vetor[i])
            {
                menor = vetor[i];
            }
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            if(menor == vetor[i])
            {
                Console.WriteLine($"O {menor} apareceu na posição {i}!");
            }
            if (maior == vetor[i])
            {
                Console.WriteLine($"O {maior} apareceu na posição {i}!");
            }
        }
    }
}