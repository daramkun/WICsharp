using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[StructLayout ( LayoutKind.Sequential )]
	public struct WICBitmapPattern
	{
		public ulong Position;
		public uint Length;
		public IntPtr Pattern;
		public IntPtr Mask;
		[MarshalAs ( UnmanagedType.Bool )]
		public bool EndOfStream;
	}
}
