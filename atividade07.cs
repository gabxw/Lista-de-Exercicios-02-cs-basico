
using System;


  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Digite um número de ponto flutuante: ");
      var num1 = float.Parse(Console.ReadLine());
      Console.Write("\nDigite outro número de ponto flutuante: ");
      var num2 = float.Parse(Console.ReadLine());

      if (num1 >= num2) {
        Console.WriteLine("\nO primeiro número é menor ou igual");
      }else {
        Console.WriteLine("\nO primeiro número é maior");
      }

      Console.Write("\nPress any key to continue . . . ");
      Console.ReadKey(true);
    }
  }
