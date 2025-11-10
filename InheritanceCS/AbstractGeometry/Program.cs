using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;   //DllImport
using System.Windows.Forms;

namespace AbstractGeometry
{
	class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			//e.Graphics.DrawRectangle(new Pen(Color.Red), 300, 100, 500, 300);

			Rectangle rectangle = new Rectangle(100, 40, 300, 50, 3, Color.AliceBlue);
			rectangle.Info(e);

			Square square = new Square(50, 500, 50, 5, Color.Red);
			square.Info(e);

			Circle circle = new Circle(100, 700, 50, 5, Color.Yellow);
			circle.Info(e);

			IsoscelesTriangle iso = new IsoscelesTriangle(75, 150, 400, 200, 3, Color.Green);
			iso.Info(e);

			EquilateralTriangle equ = new EquilateralTriangle(50, 550, 200, 4, Color.Green);
			equ.Info(e);

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
	}
}
