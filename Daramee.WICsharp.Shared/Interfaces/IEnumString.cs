using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "00000101-0000-0000-C000-000000000046" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IEnumString
	{
		HRESULT Next (
			   uint celt,
			   /* [annotation] */
			   [Out, MarshalAs ( UnmanagedType.LPWStr )] StringBuilder rgelt,
			   /* [annotation] */
			   out uint pceltFetched);
        
        HRESULT Skip ( uint celt );
        
        HRESULT Reset ();
        
        HRESULT Clone (
			out IEnumString ppenum);
	}
}
