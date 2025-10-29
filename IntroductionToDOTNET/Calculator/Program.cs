﻿//#define CALC_IF
//#define CALC_SWITCH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static string expression = "";
		static readonly char[] operators = new char[] { '+', '-', '*', '/' };
		static string[] operands;
		static double[] values;
		static readonly char[] digits = "0123456789.".ToCharArray();
		static string[] operations;
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			//string expression = "22*33/44/2*8*3";
			expression = "22+33-44/2+8*3+1";
			//expression = Console.ReadLine();
			expression = expression.Replace(",", ".");
			expression = expression.Replace(" ", "");
			Console.WriteLine(expression);

			operands = expression.Split(operators);
			values = new double[operands.Length];
			for (int i = 0; i < operands.Length; i++)
			{
				values[i] = Convert.ToDouble(operands[i]);
				Console.Write($"{values[i]}\t");
			}
			Console.WriteLine();

			/*for (int i = 0; i < digits.Length; i++)
			{
				Console.Write($"{digits[i]}\t");
			}
			Console.WriteLine();*/

			operations = expression.Split(digits);
			operations = operations.Where(operation => operation != "").ToArray();  //LINQ
			for (int i = 0; i < operations.Length; i++)
			{
				Console.Write($"{operations[i]}\t");
			}
			Console.WriteLine();

			while (operations[0] != "")
			{
				//int i = 0;
				for (int i = 0; i < operations.Length; i++)
				{
					if (operations[i] == "*" || operations[i] == "/")
					{
						if (operations[i] == "*") values[i] *= values[i + 1];
						if (operations[i] == "/") values[i] /= values[i + 1];
						Shift(i);
						if (operations[i] == "*" || operations[i] == "/") i--;
					}
				}
				for (int i = 0; i < operations.Length; i++)
				{
					if (operations[i] == "+" || operations[i] == "-")
					{
						if (operations[i] == "+") values[i] += values[i + 1];
						if (operations[i] == "-") values[i] -= values[i + 1];
						Shift(i);
						if (operations[i] == "+" || operations[i] == "-") i--;
					}
				}
			}
			Console.WriteLine(values[0]);

#if CALC_IF
			if (expression.Contains("+"))
				Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}");
			else if (expression.Contains("-"))
				Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}");
			else if (expression.Contains("*"))
				Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}");
			else if (expression.Contains("/"))
				Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}");
			else Console.WriteLine("Error: No operation"); 
#endif

#if CALC_SWITCH
			switch (expression[expression.IndexOfAny(operators)])
			{
				case '+': Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}"); break;
				case '-': Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}"); break;
				case '*': Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}"); break;
				case '/': Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}"); break;
			} 
#endif

		}
		static void Shift(int index)
		{
			for (int i = index; i < operations.Length - 1; i++) operations[i] = operations[i + 1];
			for (int i = index + 1; i < values.Length - 1; i++) values[i] = values[i + 1];
			operations[operations.Length - 1] = "";
			values[values.Length - 1] = 0;
		}
	}
}
