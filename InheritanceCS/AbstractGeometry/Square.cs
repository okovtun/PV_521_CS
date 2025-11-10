using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractGeometry
{
	class Square:Rectangle
	{
		public Square(double side, int startX, int startY, int lineWidth, Color color) :
			base(side, side, startX, startY, lineWidth, color)
		{

		}
	}
}
