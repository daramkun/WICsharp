using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "9EDDE9E7-8DEE-47ea-99DF-E6FAF2ED44BF" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapDecoder
	{
		HRESULT QueryCapability (
			[In, MarshalAs ( UnmanagedType.Interface )] IStream pIStream,
			out uint pdwCapability );

		HRESULT Initialize (
			[In, MarshalAs ( UnmanagedType.Interface )] IStream pIStream,
			WICDecodeOptions cacheOptions );

		HRESULT GetContainerFormat (
			out Guid pguidContainerFormat );

		HRESULT GetDecoderInfo (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapDecoderInfo ppIDecoderInfo );

		HRESULT CopyPalette (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICPalette pIPalette );

		HRESULT GetMetadataQueryReader (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICMetadataQueryReader ppIMetadataQueryReader );

		HRESULT GetPreview (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapSource ppIBitmapSource );

		// Not Completed
		HRESULT GetColorContexts (
			uint cCount,
			[Out, MarshalAs ( UnmanagedType.Interface )] IntPtr [] ppIColorContexts,
			out uint pcActualCount );

		HRESULT GetThumbnail (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapSource ppIThumbnail );

		HRESULT GetFrameCount (
			out uint pCount );

		HRESULT GetFrame (
			uint index,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapFrameDecode ppIBitmapFrame );
	}
}
