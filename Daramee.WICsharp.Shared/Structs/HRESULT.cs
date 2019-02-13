using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.WICsharp
{
	public struct HRESULT
	{
		int innerHRESULT;

		public bool Succeeded => innerHRESULT == 0;
		public bool Failed => innerHRESULT < 0;

		public static explicit operator int ( HRESULT hresult ) => hresult.innerHRESULT;
		public static explicit operator HRESULT ( int hresult ) => new HRESULT ( hresult );

		public HRESULT ( int hresult ) { innerHRESULT = hresult; }
	}
}
