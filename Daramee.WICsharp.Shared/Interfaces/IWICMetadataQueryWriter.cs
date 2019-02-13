using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "A721791A-0DEF-4d06-BD91-2118BF1DB10B" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICMetadataQueryWriter : IWICMetadataQueryReader
	{
		HRESULT SetMetadataByName (
			[MarshalAs ( UnmanagedType.LPWStr )] string wzName,
			[MarshalAs ( UnmanagedType.LPStruct )] PROPVARIANT pvarValue );

		HRESULT RemoveMetadataByName (
			[MarshalAs ( UnmanagedType.LPWStr )] string wzName );
	}
}
