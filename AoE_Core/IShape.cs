﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE_Core
{
	interface IShape
	{
		bool CoversPoint(Coordinates point);
	}
}
