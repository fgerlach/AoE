using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	public static class CoveredAreaCalulator
	{
		const int UnitsPerSquare = 5;
		const int PointsPerUnit = 5;
		const int PointsPerSquare = UnitsPerSquare * PointsPerUnit;

		public static bool[,] GetCoveredArea_Circle(int range)
		{
			int areaWidth = 2 * PointsPerUnit * range + PointsPerSquare;
			int areaHeight = areaWidth;

			double center = areaWidth / 2.0;
			Coordinates origin = new Coordinates { X = center, Y = center };

			IShape circle = new Circle(
				origin,
				range * PointsPerUnit);

			return FillArea(areaWidth, areaHeight, circle);
		}

		private static bool[,] FillArea(int areaWidth, int areaHeight, IShape shape)
		{
			bool[,] nativeGrid = new bool[areaWidth, areaHeight];

			for(int targetX = 0; targetX < areaWidth; targetX++)
			{
				for(int targetY = 0; targetY < areaHeight; targetY++)
				{
					var target = new Coordinates { X = targetX, Y = targetY };
					nativeGrid[targetX, targetY] = shape.Covers(target);
				}
			}

			return nativeGrid;
		}

		private static bool[,] ToSquareGrid(bool[,] nativeGrid)
		{
			int widthInSquares = nativeGrid.GetLength(0) / PointsPerSquare;
			int heightInSquares = nativeGrid.GetLength(1) / PointsPerSquare;
			bool[,] squareGrid = new bool[widthInSquares, heightInSquares];

			throw new NotImplementedException();

			return squareGrid;
		}
	}
}
