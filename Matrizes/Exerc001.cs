using System;

class program
{
    static void Main(string[] args)
    {
        int[,] array3;
        Random Sorte = new Random();


        Console.WriteLine("Quantas linhas?");
        int linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Quantas colunas?");
        int colunas = int.Parse(Console.ReadLine());

        array3 = new int[linhas, colunas];

        //Preenchimento e Exibição

        for (int linha = 0; linha < linhas; linha++)
        {
            for (int colun = 0; colun < colunas; colun++)
            {
                array3[linha, colun] = Sorte.Next(0, 10);
                Console.Write($"{array3[linha, colun]}\t");
            }
            Console.WriteLine();
        }

        //Isolando elementos por categoria
        int soma = 0;
        for (int linha = 0; linha < linhas; linha++)
        {
            for (int colun = 0; colun < colunas; colun++)
            {
                soma += array3[linha, colun];
            }
        }
        Console.WriteLine(soma);
    }
}
