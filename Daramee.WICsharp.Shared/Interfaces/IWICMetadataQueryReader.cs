using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "30989668-E1C9-4597-B395-458EEDB808DF" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICMetadataQueryReader
	{
		HRESULT GetContainerFormat (
			out Guid pguidContainerFormat );

		HRESULT GetLocation (
			uint cchMaxLength,
			[Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder wzNamespace,
			out uint pcchActualLength );

		HRESULT GetMetadataByName (
			[MarshalAs ( UnmanagedType.LPWStr )] string wzName,
			out PROPVARIANT pvarValue );

		HRESULT GetEnumerator (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IEnumString ppIEnumString );
	}
}
