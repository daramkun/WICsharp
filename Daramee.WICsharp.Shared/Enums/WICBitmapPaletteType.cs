using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.WICsharp
{
	public enum WICBitmapPaletteType
	{
		Custom = 0,
		MedianCut = 0x1,
		FixedBW = 0x2,
		FixedHalftone8 = 0x3,
		FixedHalftone27 = 0x4,
		FixedHalftone64 = 0x5,
		FixedHalftone125 = 0x6,
		FixedHalftone216 = 0x7,
		FixedWebPalette = FixedHalftone216,
		FixedHalftone252 = 0x8,
		FixedHalftone256 = 0x9,
		FixedGray4 = 0xa,
		FixedGray16 = 0xb,
		FixedGray256 = 0xc,
	}
}
