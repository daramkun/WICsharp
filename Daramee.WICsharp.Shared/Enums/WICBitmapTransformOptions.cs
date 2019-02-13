using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.WICsharp
{
	public enum WICBitmapTransformOptions
	{
		Rotate0 = 0,
		Rotate90 = 0x1,
		Rotate180 = 0x2,
		Rotate270 = 0x3,
		FlipHorizontal = 0x8,
		FlipVertical = 0x10,
	}
}
