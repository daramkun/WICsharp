using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Daramee.WICsharp
{
	[ComImport
		, Guid ( "00000040-a8f2-4877-ba0a-fd2b6645fb94" )
		, InterfaceType ( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IWICPalette
	{
		HRESULT InitializePredefined (
			   WICBitmapPaletteType ePaletteType,
			   [In, MarshalAs ( UnmanagedType.Bool )] bool fAddTransparentColor );

		HRESULT InitializeCustom (
			uint [] pColors,
			uint cCount );

		HRESULT InitializeFromBitmap (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICBitmapSource pISurface,
			uint cCount,
			[In, MarshalAs ( UnmanagedType.Bool )] bool fAddTransparentColor );

		HRESULT InitializeFromPalette (
			[In, MarshalAs ( UnmanagedType.Interface )] IWICPalette pIPalette );

		HRESULT GetType (
			out WICBitmapPaletteType pePaletteType );

		HRESULT GetColorCount (
			out uint pcCount );

		HRESULT GetColors (
			uint cCount,
			[Out] uint [] pColors,
			out uint pcActualColors );

		HRESULT IsBlackWhite (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfIsBlackWhite );

		HRESULT IsGrayscale (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfIsGrayscale );

		HRESULT HasAlpha (
			[Out, MarshalAs ( UnmanagedType.Bool )] out bool pfHasAlpha );
	}
}
