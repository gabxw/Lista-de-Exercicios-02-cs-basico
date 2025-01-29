/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 09:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace atividade2
{
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
			
			if (num1 <= num2 || num1 <= num3) {
				Console.WriteLine("\nO primeiro número é maior");
			}else {
				Console.WriteLine("\nO primeiro número não é o maior");
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}