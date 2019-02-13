using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "00000105-a8f2-4877-ba0a-fd2b6645fb94" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapFrameEncode
	{
		HRESULT Initialize (
			[MarshalAs ( UnmanagedType.Interface )] IPropertyBag2 pIEncoderOptions );

		HRESULT SetSize (
			uint uiWidth,
			uint uiHeight );

		HRESULT SetResolution (
			double dpiX,
			double dpiY );

		HRESULT SetPixelFormat (
			[MarshalAs ( UnmanagedType.LPStruct )] Guid pPixelFormat );

		// No Completed
		HRESULT SetColorContexts (
		   uint cCount,
		   [MarshalAs ( UnmanagedType.Interface )] IntPtr [] ppIColorContext );

		HRESULT SetPalette (
		   [MarshalAs ( UnmanagedType.Interface )] IWICPalette pIPalette );

		HRESULT SetThumbnail (
		   [MarshalAs ( UnmanagedType.Interface )] IWICBitmapSource pIThumbnail );

		HRESULT WritePixels (
		   uint lineCount,
		   uint cbStride,
		   uint cbBufferSize,
		   IntPtr pbPixels );

		HRESULT WriteSource (
		   [MarshalAs ( UnmanagedType.Interface )] IWICBitmapSource pIBitmapSource,
		   ref WICRect prc );

		HRESULT Commit ();

		HRESULT GetMetadataQueryWriter (
		   [Out, MarshalAs ( UnmanagedType.Interface )] out IWICMetadataQueryWriter ppIMetadataQueryWriter );
	}
}
