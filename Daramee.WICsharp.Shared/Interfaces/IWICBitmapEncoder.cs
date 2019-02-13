using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "00000103-a8f2-4877-ba0a-fd2b6645fb94" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapEncoder
	{
		HRESULT Initialize (
			[MarshalAs ( UnmanagedType.Interface )] IStream pIStream,
			WICBitmapEncoderCacheOption cacheOption );

		HRESULT GetContainerFormat (
		   out Guid pguidContainerFormat );

		HRESULT GetEncoderInfo (
		   [Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapEncoderInfo ppIEncoderInfo );

		HRESULT SetColorContexts (
		   uint cCount,
		   [Out, MarshalAs ( UnmanagedType.Interface )] out IntPtr ppIColorContext );

		HRESULT SetPalette (
		   [MarshalAs ( UnmanagedType.Interface )] IWICPalette pIPalette );

		HRESULT SetThumbnail (
		   [MarshalAs ( UnmanagedType.Interface )] IWICBitmapSource pIThumbnail );

		HRESULT SetPreview (
		   [MarshalAs ( UnmanagedType.Interface )] IWICBitmapSource pIPreview );

		HRESULT CreateNewFrame (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapFrameEncode ppIFrameEncode,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IPropertyBag2 ppIEncoderOptions );

		HRESULT Commit ();

		HRESULT GetMetadataQueryWriter (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICMetadataQueryWriter ppIMetadataQueryWriter );
	}
}
