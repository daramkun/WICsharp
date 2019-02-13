using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "5009834F-2D6A-41ce-9E1B-17C5AFF7A782" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapFlipRotator : IWICBitmapSource
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
			WICBitmapTransformOptions options );
	}
}
