using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "3127CA40-446E-11CE-8135-00AA004BB851" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IErrorLog
	{
		HRESULT AddError (
			  string pszPropName,
			  [MarshalAs ( UnmanagedType.LPStruct )] EXCEPINFO pExcepInfo );
	}
}
