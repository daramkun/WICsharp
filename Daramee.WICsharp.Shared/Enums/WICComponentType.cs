﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.WICsharp
{
	[Flags]
	public enum WICComponentType
	{
		WICDecoder = 0x1,
		WICEncoder = 0x2,
		WICPixelFormatConverter = 0x4,
		WICMetadataReader = 0x8,
		WICMetadataWriter = 0x10,
		WICPixelFormat = 0x20,
		WICAllComponents = 0x3f,
	}
}
