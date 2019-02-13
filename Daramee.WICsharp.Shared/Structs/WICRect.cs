using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[StructLayout ( LayoutKind.Sequential )]
	public struct WICRect
	{
		public int X;
		public int Y;
		public int Width;
		public int Height;

		public WICRect ( int x, int y, int width, int height )
		{
			X = x; Y = y;
			Width = width; Height = height;
		}
	}
}
