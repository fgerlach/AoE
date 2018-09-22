using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	internal class Cone : IShape
	{
		const double OpeningAngle = 53.0;

		private readonly Coordinates _Origin;
		private readonly double _Length;
		private readonly double _FacingAngle;

		internal Cone(Coordinates origin, double length, double facingAngle)
		{
			_Origin = origin;
			_Length = length;
			_FacingAngle = facingAngle;
		}

		public bool Covers(Coordinates point)
		{
			throw new NotImplementedException();

			Coordinates offset = _Origin - point;

			double distance = Math.Sqrt(Math.Pow(offset.X, 2) + Math.Pow(offset.Y, 2));

			double angle = Math.Atan2(offset.Y, offset.X);

			return distance <= _Length && angle <= _FacingAngle / 2;
		}
	}
}
