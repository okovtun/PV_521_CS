using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	class EquilateralTriangle:IsoscelesTriangle
	{
		public EquilateralTriangle(double side, int startX, int startY, int lineWidth, System.Drawing.Color color) :
			base(side, side, startX, startY, lineWidth, color)
		{ }
	}
}
