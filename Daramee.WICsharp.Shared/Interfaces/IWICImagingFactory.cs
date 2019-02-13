using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "ec5ec8a9-c395-4314-9c77-54d7a935ff70" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICImagingFactory
	{
		HRESULT CreateDecoderFromFilename (
			[MarshalAs ( UnmanagedType.LPWStr )] string wzFilename,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pguidVendor,
			uint dwDesiredAccess,
			WICDecodeOptions metadataOptions,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapDecoder ppIDecoder );

		HRESULT CreateDecoderFromStream (
			[In, MarshalAs ( UnmanagedType.Interface )] IStream pIStream,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pguidVendor,
			WICDecodeOptions metadataOptions,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapDecoder ppIDecoder );

		HRESULT CreateDecoderFromFileHandle (
			IntPtr hFile,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pguidVendor,
			WICDecodeOptions metadataOptions,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapDecoder ppIDecoder );

		HRESULT CreateComponentInfo (
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid clsidComponent,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICComponentInfo ppIInfo );

		HRESULT CreateDecoder (
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid guidContainerFormat,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pguidVendor,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapDecoder ppIDecoder );

		HRESULT CreateEncoder (
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid guidContainerFormat,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pguidVendor,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapEncoder ppIEncoder );

		HRESULT CreatePalette (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICPalette ppIPalette );

		HRESULT CreateFormatConverter (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICFormatConverter ppIFormatConverter );

		HRESULT CreateBitmapScaler (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapScaler ppIBitmapScaler );

		HRESULT CreateBitmapClipper (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapClipper ppIBitmapClipper );

		HRESULT CreateBitmapFlipRotator (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapFlipRotator ppIBitmapFlipRotator );

		// Not Complete
		HRESULT CreateStream (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IntPtr ppIWICStream );

		// Not Complete
		HRESULT CreateColorContext (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IntPtr ppIWICColorContext );

		// Not Complete
		HRESULT CreateColorTransformer (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IntPtr ppIWICColorTransform );

		HRESULT CreateBitmap (
			uint uiWidth,
			uint uiHeight,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pixelFormat,
			WICBitmapCreateCacheOption option,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmap ppIBitmap );

		HRESULT CreateBitmapFromSource (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICBitmapSource pIBitmapSource,
			WICBitmapCreateCacheOption option,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmap ppIBitmap );

		HRESULT CreateBitmapFromSourceRect (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICBitmapSource pIBitmapSource,
			uint x,
			uint y,
			uint width,
			uint height,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmap ppIBitmap );

		HRESULT CreateBitmapFromMemory (
			uint uiWidth,
			uint uiHeight,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pixelFormat,
			uint cbStride,
			uint cbBufferSize,
			IntPtr pbBuffer,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmap ppIBitmap );

		HRESULT CreateBitmapFromHBITMAP (
			IntPtr hBitmap,
			IntPtr hPalette,
			WICBitmapAlphaChannelOption options,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmap ppIBitmap );

		HRESULT CreateBitmapFromHICON (
			IntPtr hIcon,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmap ppIBitmap );

		HRESULT CreateComponentEnumerator (
			uint componentTypes,
			uint options,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IntPtr ppIEnumUnknown );

		HRESULT CreateFastMetadataEncoderFromDecoder (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICBitmapDecoder pIDecoder,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICFastMetadataEncoder ppIFastEncoder );

		HRESULT CreateFastMetadataEncoderFromFrameDecode (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICBitmapFrameDecode pIFrameDecoder,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICFastMetadataEncoder ppIFastEncoder );

		HRESULT CreateQueryWriter (
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid guidMetadataFormat,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pguidVendor,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICMetadataQueryWriter ppIQueryWriter );

		HRESULT CreateQueryWriterFromReader (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICMetadataQueryReader pIQueryReader,
			[In, MarshalAs ( UnmanagedType.LPStruct )] Guid pguidVendor,
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICMetadataQueryWriter ppIQueryWriter );
	}
}
