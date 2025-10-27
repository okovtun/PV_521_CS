using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите выражение: ");
			string expression = Console.ReadLine();
			Calculator calc = new Calculator(expression);
			double result = calc.Calculate();

			Console.WriteLine($"{ expression}   =   { result}");
		}
	}
}