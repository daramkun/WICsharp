using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "E4FBCF03-223D-4e81-9333-D635556DD1B5" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapClipper : IWICBitmapSource
	{
		new HRESULT GetSize (
			out uint puiWidth,
			out uint puiHeight );

		new HRESULT GetPixelFormat (
			out Guid pPixelFormat );

		new HRESULT GetResolution (
			out double pDpiX,
			out double pDpiY );

		new HRESULT CopyPalette (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICPalette pIPalette );

		new HRESULT CopyPixels (
			ref WICRect prc,
			uint cbStride,
			uint cbBufferSize,
			IntPtr pbBuffer );

		HRESULT Initialize (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICBitmapSource pISource,
			ref WICRect prc );
	}
}
