
using System;


  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Digite um número inteiro: ");
      var num1 = int.Parse(Console.ReadLine());
      Console.Write("\nDigite outro número inteiro: ");
      var num2 = int.Parse(Console.ReadLine());
      Console.Write("\nDigite mais um número inteiro: ");
      var num3 = int.Parse(Console.ReadLine());

      if (num1 <= num2 && num1 > num3) {
        Console.WriteLine("\nO primeiro número é menor que o segundo e maior que o terceiro");
      }else {
        Console.WriteLine("\nNão satisfaz as condições ");
      }

      Console.Write("\nPress any key to continue . . . ");
      Console.ReadKey(true);
    }
  }
