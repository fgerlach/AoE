using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	struct Coordinates
	{
		public double X;
		public double Y;

		public static Coordinates operator-(Coordinates left, Coordinates right)
		{
			return new Coordinates
			{
				X = left.X - right.X,
				Y = left.Y - right.Y
			};
		}
	}
}
