using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.WICsharp
{
	public enum WICBitmapDitherType
	{
		None = 0,
		Solid = 0,
		Ordered4x4 = 0x1,
		Ordered8x8 = 0x2,
		Ordered16x16 = 0x3,
		Spiral4x4 = 0x4,
		Spiral8x8 = 0x5,
		DualSpiral4x4 = 0x6,
		DualSpiral8x8 = 0x7,
		ErrorDiffusion = 0x8,
	}
}
