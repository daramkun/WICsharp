using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.WICsharp
{
	public enum WICBitmapInterpolationMode
	{
		NearestNeighbor = 0,
		Linear = 0x1,
		Cubic = 0x2,
		Fant = 0x3,
		HighQualityCubic = 0x4,
	}
}
