
using System;


  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Digite um número inteiro: ");
      var num1 = int.Parse(Console.ReadLine());
      Console.Write("\nDigite outro número inteiro: ");
      var num2 = int.Parse(Console.ReadLine());

      if (num1 >= num2 - 10) {
        Console.WriteLine("\ntem uma diferença menor ou igual a 10 entre os números");
      }else {
        Console.WriteLine("\nNão se tem uma diferença menor ou igual a 10");
      }

      Console.Write("\nPress any key to continue . . . ");
      Console.ReadKey(true);
    }
  }
