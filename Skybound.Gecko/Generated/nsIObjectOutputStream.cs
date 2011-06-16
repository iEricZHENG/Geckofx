// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIObjectOutputStream.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// @See nsIObjectInputStream
    /// @See nsIBinaryOutputStream
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("92c898ac-5fde-4b99-87b3-5d486422094b")]
	public interface nsIObjectOutputStream : nsIBinaryOutputStream
	{
		
		/// <summary>
        /// Close the stream. Forces the output stream to flush any buffered data.
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if unable to flush without blocking
        /// the calling thread (non-blocking mode only)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close();
		
		/// <summary>
        /// Flush the stream.
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if unable to flush without blocking
        /// the calling thread (non-blocking mode only)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Flush();
		
		/// <summary>
        /// Write data into the stream.
        ///
        /// @param aBuf the buffer containing the data to be written
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint Write([MarshalAs(UnmanagedType.LPStr)] string aBuf, uint aCount);
		
		/// <summary>
        /// Writes data into the stream from an input stream.
        ///
        /// @param aFromStream the stream containing the data to be written
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        ///
        /// NOTE: This method is defined by this interface in order to allow the
        /// output stream to efficiently copy the data from the input stream into
        /// its internal buffer (if any). If this method was provided as an external
        /// facility, a separate char* buffer would need to be used in order to call
        /// the output stream's other Write method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint WriteFrom([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, uint aCount);
		
		/// <summary>
        /// Low-level write method that has access to the stream's underlying buffer.
        /// The reader function may be called multiple times for segmented buffers.
        /// WriteSegments is expected to keep calling the reader until either there
        /// is nothing left to write or the reader returns an error.  WriteSegments
        /// should not call the reader with zero bytes to provide.
        ///
        /// @param aReader the "provider" of the data to be written
        /// @param aClosure opaque parameter passed to reader
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws NS_ERROR_NOT_IMPLEMENTED if the stream has no underlying buffer
        /// @throws <other-error> on failure
        ///
        /// NOTE: this function may be unimplemented if a stream has no underlying
        /// buffer (e.g., socket output stream).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint WriteSegments(System.IntPtr aReader, System.IntPtr aClosure, uint aCount);
		
		/// <summary>
        /// @return true if stream is non-blocking
        ///
        /// NOTE: writing to a blocking output stream will block the calling thread
        /// until all given data can be consumed by the stream.
        ///
        /// NOTE: a non-blocking output stream may implement nsIAsyncOutputStream to
        /// provide consumers with a way to wait for the stream to accept more data
        /// once its write method is unable to accept any data without blocking.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsNonBlocking();
		
		/// <summary>
        /// This interface allows writing of primitive data types (integers,
        /// floating-point values, booleans, etc.) to a stream in a binary, untagged,
        /// fixed-endianness format.  This might be used, for example, to implement
        /// network protocols or to produce architecture-neutral binary disk files,
        /// i.e. ones that can be read and written by both big-endian and little-endian
        /// platforms.  Output is written in big-endian order (high-order byte first),
        /// as this is traditional network order.
        ///
        /// @See nsIBinaryInputStream
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOutputStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aOutputStream);
		
		/// <summary>
        /// Write a boolean as an 8-bit char to the stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void WriteBoolean([MarshalAs(UnmanagedType.Bool)] bool aBoolean);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write8(byte aByte);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write16(ushort a16);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write32(uint a32);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write64(ulong a64);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void WriteFloat(double aFloat);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void WriteDouble(double aDouble);
		
		/// <summary>
        /// Write an 8-bit pascal style string to the stream.
        /// 32-bit length field, followed by length 8-bit chars.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void WriteStringZ([MarshalAs(UnmanagedType.LPStr)] string aString);
		
		/// <summary>
        /// Write a 16-bit pascal style string to the stream.
        /// 32-bit length field, followed by length PRUnichars.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void WriteWStringZ([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aString);
		
		/// <summary>
        /// Write an 8-bit pascal style string (UTF8-encoded) to the stream.
        /// 32-bit length field, followed by length 8-bit chars.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void WriteUtf8Z([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aString);
		
		/// <summary>
        /// Write an opaque byte array to the stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void WriteBytes([MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)] string aString, uint aLength);
		
		/// <summary>
        /// Write an opaque byte array to the stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void WriteByteArray(byte aBytes, uint aLength);
		
		/// <summary>
        /// Write the object whose "root" or XPCOM-identity nsISupports is aObject.
        /// The cause for writing this object is a strong or weak reference, so the
        /// aIsStrongRef argument must tell which kind of pointer is being followed
        /// here during serialization.
        ///
        /// If the object has only one strong reference in the serialization and no
        /// weak refs, use writeSingleRefObject.  This is a valuable optimization:
        /// it saves space in the stream, and cycles on both ends of the process.
        ///
        /// If the reference being serialized is a pointer to an interface not on
        /// the primary inheritance chain ending in the root nsISupports, you must
        /// call writeCompoundObject instead of this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WriteObject([MarshalAs(UnmanagedType.Interface)] nsISupports aObject, [MarshalAs(UnmanagedType.Bool)] bool aIsStrongRef);
		
		/// <summary>
        /// Write an object referenced singly and strongly via its root nsISupports
        /// or a subclass of its root nsISupports.  There must not be other refs to
        /// aObject in memory, or in the serialization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WriteSingleRefObject([MarshalAs(UnmanagedType.Interface)] nsISupports aObject);
		
		/// <summary>
        /// Write the object referenced by an interface pointer at aObject that
        /// inherits from a non-primary nsISupports, i.e., a reference to one of
        /// the multiply inherited interfaces derived from an nsISupports other
        /// than the root or XPCOM-identity nsISupports; or a reference to an
        /// inner object in the case of true XPCOM aggregation.  aIID identifies
        /// this interface.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WriteCompoundObject([MarshalAs(UnmanagedType.Interface)] nsISupports aObject, ref System.Guid aIID, [MarshalAs(UnmanagedType.Bool)] bool aIsStrongRef);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WriteID(System.IntPtr aID);
		
		/// <summary>
        /// Optimized serialization support -- see nsIStreamBufferAccess.idl.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetBuffer(uint aLength, uint aAlignMask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PutBuffer(System.IntPtr aBuffer, uint aLength);
	}
}
