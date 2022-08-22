using System;

class program
{
    static void Main(string[] args)
    {
        Random Sorte = new Random();
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Sorte.Next(0, 10);
            Console.WriteLine(numeros[i]);
        }
    }
}