
using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        var num1 = float.Parse(Console.ReadLine());


        if (num1 % 2 == 0)
        {
            Console.WriteLine("\nO primeiro número é par");
        }
        else
        {
            Console.WriteLine("\nO segundo número é impar");
        }

        Console.Write("\nPress any key to continue . . . ");
        Console.ReadKey(true);
    }
}
