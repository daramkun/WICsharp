using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "00000121-a8f2-4877-ba0a-fd2b6645fb94" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmap : IWICBitmapSource
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

		HRESULT Lock (
			ref WICRect prcLock,
			uint flags,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapLock ppILock );

		HRESULT SetPalette (
			[MarshalAs ( UnmanagedType.Interface )] IWICPalette pIPalette );

		HRESULT SetResolution (
			double dpiX,
			double dpiY );
	}
}
