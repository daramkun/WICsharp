using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "ec5ec8a9-c395-4314-9c77-54d7a935ff70" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )
		, CoClass ( typeof ( WICImagingFactoryClass ) )]
	public interface WICImagingFactory : IWICImagingFactory { }

	[ComImport
		, Guid ( "cacaf262-9370-4615-a13b-9f5539da4c0a" )
		, ComDefaultInterface ( typeof ( IWICImagingFactory ) )]
	public class WICImagingFactoryClass { }
}
