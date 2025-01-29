
using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        var num1 = float.Parse(Console.ReadLine());


        if (num1 >= 0)
        {
            Console.WriteLine("\nO primeiro número é positivo");
        }
        else
        {
            Console.WriteLine("\nO segundo número é negativo");
        }

        Console.Write("\nPress any key to continue . . . ");
        Console.ReadKey(true);
    }
}
