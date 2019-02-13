using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[StructLayout ( LayoutKind.Explicit, Size = 16 )]
	public struct VARIANT
	{
		[FieldOffset ( 0 )]
		public ushort vt;
		[FieldOffset ( 2 )]
		public ushort wReserved1;
		[FieldOffset ( 4 )]
		public ushort wReserved2;
		[FieldOffset ( 6 )]
		public ushort wReserved3;

		[FieldOffset ( 8 )]
		public long llVal;

		[FieldOffset ( 8 )]
		public int lVal;

		[FieldOffset ( 8 )]
		public byte bVal;

		[FieldOffset ( 8 )]
		public short iVal;

		[FieldOffset ( 8 )]
		public float fltVal;

		[FieldOffset ( 8 )]
		public double dblVal;

		[FieldOffset ( 8 )]
		public short boolVal;

		[FieldOffset ( 8 )]
		public int scode;

		[FieldOffset ( 8 )]
		public double date;

		[FieldOffset ( 8 )]
		public unsafe ushort* bstrVal;

		[FieldOffset ( 8 )]
		public unsafe byte* pbVal;

		[FieldOffset ( 8 )]
		public unsafe short* piVal;

		[FieldOffset ( 8 )]
		public unsafe int* plVal;

		[FieldOffset ( 8 )]
		public unsafe long* pllVal;

		[FieldOffset ( 8 )]
		public unsafe float* pfltVal;

		[FieldOffset ( 8 )]
		public unsafe double* pdblVal;

		[FieldOffset ( 8 )]
		public unsafe short* pboolVal;

		[FieldOffset ( 8 )]
		public unsafe int* pscode;

		[FieldOffset ( 8 )]
		public unsafe double* pdate;

		[FieldOffset ( 8 )]
		public unsafe ushort** pbstrVal;

		[FieldOffset ( 8 )]
		public unsafe VARIANT* pvarVal;

		[FieldOffset ( 8 )]
		public unsafe void* byref;

		[FieldOffset ( 8 )]
		public sbyte cVal;

		[FieldOffset ( 8 )]
		public ushort uiVal;

		[FieldOffset ( 8 )]
		public uint ulVal;

		[FieldOffset ( 8 )]
		public ulong ullVal;

		[FieldOffset ( 8 )]
		public int intVal;

		[FieldOffset ( 8 )]
		public uint uintVal;

		[FieldOffset ( 8 )]
		public unsafe sbyte* pcVal;

		[FieldOffset ( 8 )]
		public unsafe ushort* puiVal;

		[FieldOffset ( 8 )]
		public unsafe uint* pulVal;

		[FieldOffset ( 8 )]
		public unsafe ulong* pullVal;

		[FieldOffset ( 8 )]
		public unsafe int* pintVal;

		[FieldOffset ( 8 )]
		public unsafe uint* puintVal;

		[FieldOffset ( 8 )]
		public unsafe void* pvRecord;
	}
}
