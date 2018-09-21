using AoE_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			for(int rangeFeet = 5; rangeFeet <= 20; rangeFeet += 5)
			{
				CreateCircle(rangeFeet);
				Console.WriteLine();
			}

			Console.ReadKey();
		}

		private static void CreateCircle(int rangeFeet)
		{
			bool[,] coveredAreaCicle = CoveredAreaCalulator.GetCoveredArea_Circle(rangeFeet);
			PrintResult(coveredAreaCicle);
		}

		private static void PrintResult(bool[,] coveredAreaCicle)
		{
			for(int y = 0; y < coveredAreaCicle.GetLength(0); y++)
			{
				for(int x = 0; x < coveredAreaCicle.GetLength(1); x++)
				{
					Console.Write(coveredAreaCicle[x, y] ? "X" : ".");
				}
				Console.WriteLine();
			}
		}
	}
}
