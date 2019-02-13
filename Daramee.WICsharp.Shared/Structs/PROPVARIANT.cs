using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[StructLayout ( LayoutKind.Explicit, Size = 32 )]
	public struct PROPVARIANT
	{
		[FieldOffset ( 0 )]
		public VARTYPE vt;
		[FieldOffset ( 2 )]
		ushort wReserved1;
		[FieldOffset ( 4 )]
		ushort wReserved2;
		[FieldOffset ( 6 )]
		ushort wReserved3;

		[FieldOffset ( 8 )]
		public sbyte cVal;

		[FieldOffset ( 8 )]
		public byte bVal;

		[FieldOffset ( 8 )]
		public short iVal;

		[FieldOffset ( 8 )]
		public ushort uiVal;

		[FieldOffset ( 8 )]
		public int lVal;

		[FieldOffset ( 8 )]
		public uint ulVal;

		[FieldOffset ( 8 )]
		public long hVal;

		[FieldOffset ( 8 )]
		public ulong uhVal;

		[FieldOffset ( 8 )]
		public float fltVal;

		[FieldOffset ( 8 )]
		public double dblVal;

		[FieldOffset ( 8 )]
		public IntPtr Ptr;
	}
}
