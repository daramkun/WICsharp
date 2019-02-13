using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "D8CD007F-D08F-4191-9BFC-236EA7F0E4B5" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapDecoderInfo : IWICBitmapCodecInfo
	{
		new HRESULT GetComponentType (
					 out WICComponentType pType );

		new HRESULT GetCLSID (
			out Guid pclsid );

		new HRESULT GetSigningStatus (
			out uint pStatus );

		new HRESULT GetAuthor (
			uint cchAuthor,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzAuthor,
			out uint pcchActual );

		new HRESULT GetVendorGUID (
			out Guid pguidVendor );

		new HRESULT GetVersion (
			uint cchVersion,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzVersion,
			out uint pcchActual );

		new HRESULT GetSpecVersion (
			uint cchSpecVersion,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzSpecVersion,
			out uint pcchActual );

		new HRESULT GetFriendlyName (
			uint cchFriendlyName,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzFriendlyName,
			out uint pcchActual );

		new HRESULT GetContainerFormat (
			out Guid pguidContainerFormat );

		new HRESULT GetPixelFormats (
			uint cFormats,
			Guid [] pguidPixelFormats,
			out uint pcActual );

		new HRESULT GetColorManagementVersion (
			uint cchColorManagementVersion,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzColorManagementVersion,
			out uint pcchActual );

		new HRESULT GetDeviceManufacturer (
			uint cchDeviceManufacturer,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzDeviceManufacturer,
			out uint pcchActual );

		new HRESULT GetDeviceModels (
			uint cchDeviceModels,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzDeviceModels,
			out uint pcchActual );

		new HRESULT GetMimeTypes (
			uint cchMimeTypes,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzMimeTypes,
			out uint pcchActual );

		new HRESULT GetFileExtensions (
			uint cchFileExtensions,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzFileExtensions,
			out uint pcchActual );

		new HRESULT DoesSupportAnimation (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfSupportAnimation );

		new HRESULT DoesSupportChromakey (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfSupportChromakey );

		new HRESULT DoesSupportLossless (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfSupportLossless );

		new HRESULT DoesSupportMultiframe (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfSupportMultiframe );

		new HRESULT MatchesMimeType (
			string wzMimeType,
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfMatches );

		HRESULT GetPatterns (
			uint cbSizePatterns,
			WICBitmapPattern [] pPatterns,
			out uint pcPatterns,
			out uint pcbPatternsActual);
        
        HRESULT MatchesPattern (
			[MarshalAs ( UnmanagedType.Interface )] IStream pIStream,
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfMatches );
        
        HRESULT CreateInstance (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICBitmapDecoder ppIBitmapDecoder);
	}
}
