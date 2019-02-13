using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[UnmanagedFunctionPointer ( CallingConvention.StdCall )]
	public delegate HRESULT DeferredFillIn ( out EXCEPINFO info );

	public struct EXCEPINFO
	{
		public ushort wCode;
		public ushort wReserved;
		public string bstrSource;
		public string bstrDescription;
		public string bstrHelpFile;
		public uint dwHelpContext;
		public IntPtr pvReserved;
		public DeferredFillIn pfnDeferredFillIn;
		public int scode;
	}
}
