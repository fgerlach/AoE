using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	internal class Line : IShape
	{
		private readonly Coordinates _Origin;
		private readonly double _Length;
		private readonly double _Width;
		private readonly double _FacingAngle;

		internal Line(Coordinates origin, double length, double width, double facingAngle)
		{
			_Origin = origin;
			_Length = length;
			_Width = width;
			_FacingAngle = facingAngle;
		}

		public bool Covers(Coordinates point)
		{
			throw new NotImplementedException();

			Coordinates offset = _Origin - point;

			double distance = Math.Sqrt(Math.Pow(offset.X, 2) + Math.Pow(offset.Y, 2));

			return distance <= _Length;
		}
	}
}
