using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
	class Point
	{
		//private, public, protected,
		//internal - поля доступны в любом месте сборки
		//protected internal - поля доступны только для дочерних классов в пределах сборки
		//double x;
		//double y;
		////Properties - это синтаксическая конструкция, которая объединяет Get и Set метод,
		////			   и позволяет использовать их как обычную переменную в классе.
		///// Properties /////////////////////////////////////////////////////////////////////////////
		//public double X
		//{
		//	get
		//	{
		//		return x;
		//	}
		//	set
		//	{
		//		if (value > 100) value = 100;
		//		x = value;	//value - возвращает принимаемое значение.
		//	}
		//}
		//public double Y
		//{
		//	get
		//	{
		//		return y;
		//	}
		//	set
		//	{
		//		if (value > 100) value = 100;
		//		y = value;
		//	}
		//}
		// EndProperties /////////////////////////////////////////////////////////////////////////////
		public double X { get; set; }	//Auto properties
		public double Y { get; set; }   //Auto properties
										//public double GetX()
										//{
										//	return x;
										//}
										//public double GetY()
										//{
										//	return y;
										//}
										//public void SetX(double x)
										//{
										//	this.x = x;
										//}
										//public void SetY(double y)
										//{
										//	this.y = y;
										//}

		/*
		Garbage collector
		*/
		public Point(double x = 0, double y = 0)
		{
			X = x;
			Y = y;
			Console.WriteLine($"Constructor:\t{this.GetHashCode()}");
		}
		public Point(Point other)
		{
			this.X = other.X;
			this.Y = other.Y;
			Console.WriteLine($"CopyConstructor:{this.GetHashCode()}");
		}
		~Point()
		{
			Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
		}
		//			Operators:
		public static Point operator+(Point left, Point right)
		{
			return new Point
				(
					left.X+right.X,
					left.Y+right.Y
				);
		}
		public void Info()
		{
			Console.WriteLine($"X = {X}, Y = {Y}");
		}
	}
}
