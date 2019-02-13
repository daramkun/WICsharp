using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daramee.WICsharp;

namespace Test
{
	class Program
	{
		static void Main ( string [] args )
		{
			IWICImagingFactory factory = new WICImagingFactory ();
			factory.CreateDecoder ( ContainerFormats.Png, Vendors.Microsoft, out IWICBitmapDecoder decoder );
			using ( Stream inputStream = new FileStream ( "Test.png", FileMode.Open ) )
			{
				decoder.Initialize ( inputStream.AsIStream (), WICDecodeOptions.MetadataCacheOnDemand );
				decoder.GetFrame ( 0, out IWICBitmapFrameDecode bitmapFrame );

				bitmapFrame.GetSize ( out uint width, out uint height );
				bitmapFrame.GetResolution ( out double dpiX, out double dpiY );
				Console.WriteLine ( $"Width: {width}, Height: {height}, DPI: {dpiX}x{dpiY}" );

				factory.CreateFormatConverter ( out IWICFormatConverter formatConverter );
				formatConverter.Initialize ( bitmapFrame, PixelFormats.PixelFormat32bppBGRA, WICBitmapDitherType.None, null, 1, WICBitmapPaletteType.Custom );

				using ( Stream outputStream = new FileStream ( "Output.png", FileMode.Create ) )
				{
					factory.CreateEncoder ( ContainerFormats.Png, Vendors.Microsoft, out IWICBitmapEncoder encoder );

					encoder.Initialize ( outputStream.AsIStream (), WICBitmapEncoderCacheOption.NoCache );
					encoder.CreateNewFrame ( out IWICBitmapFrameEncode frameEncode, out IPropertyBag2 encoderOptions );

					frameEncode.Initialize ( encoderOptions );
					frameEncode.SetPixelFormat ( PixelFormats.PixelFormat32bppBGRA );
					frameEncode.SetSize ( width, height );
					frameEncode.SetResolution ( dpiX, dpiY );

					WICRect rect = new WICRect ( 0, 0, ( int ) width, ( int ) height );
					frameEncode.WriteSource ( formatConverter, ref rect );

					frameEncode.Commit ();

					encoder.Commit ();
				}
			}
		}
	}
}
