using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "3B16811B-6A43-4ec9-A813-3D930C13B940" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapFrameDecode : IWICBitmapSource
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

		HRESULT GetMetadataQueryReader (
			out IWICMetadataQueryReader ppIMetadataQueryReader );

		// No Completed
		HRESULT GetColorContexts (
			uint cCount,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IntPtr ppIColorContexts,
			out uint pcActualCount );

		HRESULT GetThumbnail (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapSource ppIThumbnail );
	}
}
