using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "23BC3F0A-698B-4357-886B-F24D50671334" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICComponentInfo
	{
		HRESULT GetComponentType (
			   out WICComponentType pType );

		HRESULT GetCLSID (
			out Guid pclsid );

		HRESULT GetSigningStatus (
			out uint pStatus );

		HRESULT GetAuthor (
			uint cchAuthor,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzAuthor,
			out uint pcchActual );

		HRESULT GetVendorGUID (
			out Guid pguidVendor );

		HRESULT GetVersion (
			uint cchVersion,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzVersion,
			out uint pcchActual );

		HRESULT GetSpecVersion (
			uint cchSpecVersion,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzSpecVersion,
			out uint pcchActual );

		HRESULT GetFriendlyName (
			uint cchFriendlyName,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzFriendlyName,
			out uint pcchActual );
	}
}
