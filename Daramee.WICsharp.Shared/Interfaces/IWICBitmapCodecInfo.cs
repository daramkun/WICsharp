using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "E87A44C4-B76E-4c47-8B09-298EB12A2714" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICBitmapCodecInfo : IWICComponentInfo
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

		HRESULT GetContainerFormat (
			out Guid pguidContainerFormat );

		HRESULT GetPixelFormats (
			uint cFormats,
			Guid [] pguidPixelFormats,
			out uint pcActual );

		HRESULT GetColorManagementVersion (
			uint cchColorManagementVersion,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzColorManagementVersion,
			out uint pcchActual );

		HRESULT GetDeviceManufacturer (
			uint cchDeviceManufacturer,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzDeviceManufacturer,
			out uint pcchActual );

		HRESULT GetDeviceModels (
			uint cchDeviceModels,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzDeviceModels,
			out uint pcchActual );

		HRESULT GetMimeTypes (
			uint cchMimeTypes,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzMimeTypes,
			out uint pcchActual );

		HRESULT GetFileExtensions (
			uint cchFileExtensions,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzFileExtensions,
			out uint pcchActual );

		HRESULT DoesSupportAnimation (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfSupportAnimation );

		HRESULT DoesSupportChromakey (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfSupportChromakey );

		HRESULT DoesSupportLossless (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfSupportLossless );

		HRESULT DoesSupportMultiframe (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfSupportMultiframe );

		HRESULT MatchesMimeType (
			string wzMimeType,
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfMatches );
	}
}
