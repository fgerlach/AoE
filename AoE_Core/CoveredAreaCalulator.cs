using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	public static class CoveredAreaCalulator
	{
		const int FeetPerSquare = 5;

		public static bool[,] GetCoveredArea_Circle(int range)
		{
			return FillArea(range, (Coordinates origin, Coordinates target)
				=> IsCoveredBy.Circle(range, origin, target));
		}

		public static bool[,] GetCoveredArea_Cone(int range)
		{
			return FillArea(range, (Coordinates origin, Coordinates target)
				=> IsCoveredBy.Cone(range, origin, target));
		}

		public static bool[,] GetCoveredArea_Line(int range)
		{
			const int width = 5;
			return FillArea(range, (Coordinates origin, Coordinates target)
				=> IsCoveredBy.Line(range, width, origin, target));
		}

		private static bool[,] FillArea(int range, Func<Coordinates, Coordinates, bool> check)
		{
			int marginSquares = 1;
			int rangeSquaresWithMargin = range / FeetPerSquare + marginSquares;
			int cornerLengthSquares = 2 * rangeSquaresWithMargin + 1;
			bool[,] totalArea = new bool[cornerLengthSquares, cornerLengthSquares];
			var origin = new Coordinates
			{
				X = range + marginSquares * 5,
				Y = range + marginSquares * 5,
			};

			for(int targetXSquares = 0; targetXSquares < cornerLengthSquares; targetXSquares++)
			{
				for(int targetYSquares = 0; targetYSquares < cornerLengthSquares; targetYSquares++)
				{
					var target = new Coordinates { X = targetXSquares * 5 , Y = targetYSquares * 5};
					totalArea[targetXSquares, targetYSquares] = check(origin, target);
				}
			}

			return totalArea;
		}
	}
}
