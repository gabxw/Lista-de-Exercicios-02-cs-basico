
using System;


  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Digite um número de ponto flutuante: ");
      var num1 = float.Parse(Console.ReadLine());


      if (num1 == 0) { 
        Console.WriteLine("\nÉ igual a zero.");
      }else {
        Console.WriteLine("\nNão é igual a zero.");
      }

      Console.Write("\nPress any key to continue . . . ");
      Console.ReadKey(true);  
    }
  }
