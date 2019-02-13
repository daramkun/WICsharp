using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "00000120-a8f2-4877-ba0a-fd2b6645fb94" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapSource
	{
		HRESULT GetSize (
			out uint puiWidth,
			out uint puiHeight );

		HRESULT GetPixelFormat (
			out Guid pPixelFormat );

		HRESULT GetResolution (
			out double pDpiX,
			out double pDpiY );

		HRESULT CopyPalette (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICPalette pIPalette );

		HRESULT CopyPixels (
			ref WICRect prc,
			uint cbStride,
			uint cbBufferSize,
			IntPtr pbBuffer );
	}
}
