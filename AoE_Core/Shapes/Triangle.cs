using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	internal class Triangle : IShape
	{
		private readonly Coordinates _Origin;
		private readonly double _Length;
		private readonly double _Angle;

		internal Triangle(Coordinates origin, double length, double angle)
		{
			_Origin = origin;
			_Length = length;
			_Angle = angle;
		}

		public bool Covers(Coordinates point)
		{
			throw new NotImplementedException();

			Coordinates offset = _Origin - point;

			double distance = Math.Sqrt(Math.Pow(offset.X, 2) + Math.Pow(offset.Y, 2));

			double angle = Math.Atan2(offset.Y, offset.X);

			return distance <= _Length && angle <= _Angle / 2;
		}
	}
}
