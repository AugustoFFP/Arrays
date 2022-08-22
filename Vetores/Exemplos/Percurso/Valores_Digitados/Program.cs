using System;

class program
{
    static void Main(string[] args)
    {
        int[] idade = new int[5];

        for (int posicao = 0; posicao < idade.Length; posicao++)
        {
            Console.WriteLine("Digite uma idade: ");
            idade[posicao] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nAs idades digitadas foram: ");

        for (int posicao = 0; posicao < idade.Length; posicao++)
        {
            Console.WriteLine(idade[posicao]);
        }
    }
}
