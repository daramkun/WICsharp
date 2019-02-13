using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Daramee.WICsharp
{
	public static class StreamExtensions
	{
		class NativeIStreamBridge : IStream
		{
			public Stream BaseStream { get; private set; }

			public NativeIStreamBridge ( Stream stream )
			{
				BaseStream = stream;
			}

			public void Clone ( out IStream ppstm ) { throw new NotImplementedException (); }
			public void Commit ( int grfCommitFlags ) { BaseStream.Flush (); }

			public void CopyTo ( IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten )
			{
				throw new NotImplementedException ();
			}

			public void LockRegion ( long libOffset, long cb, int dwLockType )
			{
				throw new NotImplementedException ();
			}

			public void Read ( byte [] pv, int cb, IntPtr pcbRead )
			{
				if ( !BaseStream.CanRead )
					throw new InvalidOperationException ( "Stream not readable" );
				Marshal.WriteIntPtr ( pcbRead, new IntPtr ( BaseStream.Read ( pv, 0, cb ) ) );
			}

			public void Revert ()
			{
				throw new NotImplementedException ();
			}

			public void Seek ( long dlibMove, int dwOrigin, IntPtr plibNewPosition )
			{
				Marshal.WriteIntPtr ( plibNewPosition, new IntPtr ( BaseStream.Seek ( dlibMove, ( SeekOrigin ) dwOrigin ) ) );
			}

			public void SetSize ( long libNewSize )
			{
				BaseStream.SetLength ( libNewSize );
			}

			public void Stat ( out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag )
			{
				pstatstg = new System.Runtime.InteropServices.ComTypes.STATSTG
				{
					cbSize = BaseStream.Length,
					pwcsName = ( BaseStream is FileStream ) ? ( BaseStream as FileStream ).Name : null,
				};
			}

			public void UnlockRegion ( long libOffset, long cb, int dwLockType )
			{
				throw new NotImplementedException ();
			}

			public void Write ( byte [] pv, int cb, IntPtr pcbWritten )
			{
				if ( !BaseStream.CanWrite )
					throw new InvalidOperationException ( "Stream is not writeable." );
				BaseStream.Write ( pv, 0, cb );
				Marshal.WriteIntPtr ( pcbWritten, new IntPtr ( cb ) );
			}
		}

		public static IStream AsIStream ( this Stream stream )
		{
			return new NativeIStreamBridge ( stream );
		}

		class StreamBridge : Stream
		{
			IStream originalStream_;

			public StreamBridge ( IStream stream )
			{
				if ( stream != null )
				{
					originalStream_ = stream;
				}
				else
				{
					throw new ArgumentNullException ( "stream" );
				}
			}

			~StreamBridge ()
			{
				Close ();
			}
			
			public IStream UnderlyingStream => originalStream_;
			
			public unsafe override int Read ( byte [] buffer, int offset, int count )
			{
				if ( originalStream_ == null )
					throw new ObjectDisposedException ( "originalStream_" );

				if ( offset != 0 )
					throw new NotSupportedException ( "only 0 offset is supported" );

				int bytesRead;

				IntPtr address = new IntPtr ( &bytesRead );
				originalStream_.Read ( buffer, count, address );

				return bytesRead;

			}

			public override void Write ( byte [] buffer, int offset, int count )
			{
				if ( originalStream_ == null )
					throw new ObjectDisposedException ( "originalStream_" );

				if ( offset != 0 )
					throw new NotSupportedException ( "only 0 offset is supported" );

				originalStream_.Write ( buffer, count, IntPtr.Zero );

			}
			
			public unsafe override long Seek ( long offset, SeekOrigin origin )
			{
				if ( originalStream_ == null )
					throw new ObjectDisposedException ( "originalStream_" );

				long position = 0;

				IntPtr address = new IntPtr ( &position );

				originalStream_.Seek ( offset, ( int ) origin, address );
				return position;

			}

			public override long Length
			{
				get
				{
					if ( originalStream_ == null )
						throw new ObjectDisposedException ( "originalStream_" );

					originalStream_.Stat ( out System.Runtime.InteropServices.ComTypes.STATSTG statstg, 1 /* STATSFLAG_NONAME*/ );
					return statstg.cbSize;
				}
			}

			public override long Position
			{
				get { return Seek ( 0, SeekOrigin.Current ); }
				set { Seek ( value, SeekOrigin.Begin ); }
			}

			public override void SetLength ( long value )
			{
				if ( originalStream_ == null )
					throw new ObjectDisposedException ( "originalStream_" );

				originalStream_.SetSize ( value );
			}
			
			public override void Close ()
			{
				if ( originalStream_ != null )
				{
					originalStream_.Commit ( 0 );
					// Marshal.ReleaseComObject( originalStream_ );
					originalStream_ = null;
					GC.SuppressFinalize ( this );
				}
			}

			public override void Flush ()
			{
				originalStream_.Commit ( 0 );
			}

			public override bool CanRead
			{
				get { return true; }
			}

			public override bool CanWrite
			{
				get { return true; }
			}

			public override bool CanSeek
			{
				get { return true; }
			}
		}

		public static Stream AsStream ( this IStream stream )
		{
			return new StreamBridge ( stream );
		}
	}
}
