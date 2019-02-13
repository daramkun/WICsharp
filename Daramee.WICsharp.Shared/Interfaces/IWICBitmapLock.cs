using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "00000123-a8f2-4877-ba0a-fd2b6645fb94" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapLock
	{
		HRESULT GetSize (
			   out uint puiWidth,
			   out uint puiHeight );

		HRESULT GetStride (
			out uint pcbStride );

		HRESULT GetDataPointer (
			out uint pcbBufferSize,
			out IntPtr ppbData );

		HRESULT GetPixelFormat (
			out Guid pPixelFormat );
	}
}
