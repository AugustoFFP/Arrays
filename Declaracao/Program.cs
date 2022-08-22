using System;

class program
{
    static void Main(string[] args)
    {
        //int n1, n2, n2, n3, n4, n5;
        string[] veiculos = new string[3] { "Avião", "Carro", "Nave" }; // 1 modo
        veiculos[0] = "Carro";
        veiculos[1] = "Avião";
        veiculos[2] = "Navio";



        int[] num = { 55, 77, 99 }; // 2 modo.Usa como padrão o numero de elementos que colocamos.
        Console.WriteLine(num[0]);

        Console.WriteLine(num.Length);
    }
}
