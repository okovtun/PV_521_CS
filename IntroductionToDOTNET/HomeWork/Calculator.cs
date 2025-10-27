using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class Calculator
	{
		private string expression;
		private int position;

		public Calculator(string expression)
		{
			this.expression = expression.Replace(" ", ""); //убирает пробелы
														   //Console.WriteLine(this.expression);
			this.position = 0;

		}
		public double Calculate()
		{
			double result = Calc1();

			return result;

		}
		private double Calc1()
		{
			//Console.WriteLine("Calc 1");
			double x = Calc2();
			while (position < expression.Length)
			{
				char operation = expression[position];
				if (operation != '+' && operation != '-') break;

				position++;
				double y = Calc2();
				if (operation == '+') x += y;
				else x -= y;

			}
			return x;
		}

		private double Calc2()
		{
			//Console.WriteLine("Calc 2");
			double x = Calc3();
			while (position < expression.Length)
			{
				char operation = expression[position];
				if (operation != '*' && operation != '/') break;

				position++;
				double y = Calc3();
				if (operation == '*') x *= y;
				else x /= y;
			}
			return x;
		}

		private double Calc3()
		{
			//Console.WriteLine("Calc 3");
			if (position < expression.Length && expression[position] == '(')
			{
				position++;
				double x = Calc1();
				position++;
				return x;
			}
			else
			{
				return Calc4();
			}
		}

		private double Calc4()
		{
			//Console.WriteLine("Calc 4");
			int start = position;

			while (position < expression.Length
				&& (char.IsDigit(expression[position]) || expression[position] == ','))
			{
				position++;
			}
			//вырезает число
			string numberStr = expression.Substring(start, position - start);
			//преобразует в double
			return double.Parse(numberStr);
		}

	}
}