using System;

class program
{
    static void Main(string[] args)
    {
        Busca();
    }

    static void Busca()
    {
        int[] numero = { 5, 8, 9, 4 };
        byte chave = 5;
        bool achei = false;

        for (int i = 0; i < numero.Length; i++)
        {
            if (numero[i] == chave)
            {
                Console.WriteLine($"Encontrei a chave {numero[i]} na posição {i}!");
                achei = true;
            }
        }

        if (!achei)
        {
            Console.WriteLine($"Não encontrei a chave com valor {chave}.");
        }
    }
}
