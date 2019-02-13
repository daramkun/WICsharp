using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "22F55882-280B-11d0-A8A9-00A0C90C2004" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IPropertyBag2
	{
		HRESULT Read (
			uint cProperties,
			PROPBAG2 [] pPropBag,
			[MarshalAs ( UnmanagedType.Interface )] IErrorLog pErrLog,
			VARIANT [] pvarValue,
			out HRESULT phrError );

		HRESULT Write (
			uint cProperties,
			PROPBAG2 [] pPropBag,
			VARIANT [] pvarValue );

		HRESULT CountProperties (
			out uint pcProperties );

		HRESULT GetPropertyInfo (
			uint iProperty,
			uint cProperties,
			PROPBAG2 [] pPropBag,
			out uint pcProperties );

		HRESULT LoadObject (
			string pstrName,
			uint dwHint,
			[MarshalAs ( UnmanagedType.Interface )] object pUnkObject,
			[MarshalAs ( UnmanagedType.Interface )] IErrorLog pErrLog );
	}
}
