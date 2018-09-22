using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	internal class Circle : IShape
	{
		private readonly Coordinates _Center;
		private readonly double _Radius;

		internal Circle(Coordinates center, double radius)
		{
			_Center = center;
			_Radius = radius;
		}

		public bool Covers(Coordinates point)
		{
			Coordinates offset = _Center - point;

			double distance = Math.Sqrt(Math.Pow(offset.X, 2) + Math.Pow(offset.Y, 2));

			return distance <= _Radius;
		}
	}
}
