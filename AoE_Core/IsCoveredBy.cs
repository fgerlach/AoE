using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	internal static class IsCoveredBy
	{
		private const double coneAngle = 53;

		public static bool Circle(double range, Coordinates origin, Coordinates target)
		{
			Coordinates offset = origin - target;

			double distance = Math.Sqrt(Math.Pow(offset.X, 2) + Math.Pow(offset.Y, 2));

			return distance <= range;
		}

		public static bool Cone(double range, Coordinates origin, Coordinates target)
		{
			Coordinates offset = origin - target;

			double distance = Math.Sqrt(Math.Pow(offset.X, 2) + Math.Pow(offset.Y, 2));

			double angle = Math.Atan2(offset.Y, offset.X);

			return distance <= range && angle <= coneAngle / 2;
		}

		public static bool Line(double range, double width, Coordinates origin, Coordinates target)
		{
			Coordinates offset = origin - target;

			double distance = Math.Sqrt(Math.Pow(offset.X, 2) + Math.Pow(offset.Y, 2));

			return distance <= range;
		}
	}
}
