using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "B84E2C09-78C9-4AC4-8BD3-524AE1663A2F" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICFastMetadataEncoder
	{
		HRESULT Commit ();

		HRESULT GetMetadataQueryWriter (
			[Out, MarshalAs ( UnmanagedType.Interface )] out IWICMetadataQueryWriter ppIMetadataQueryWriter);
	}
}
