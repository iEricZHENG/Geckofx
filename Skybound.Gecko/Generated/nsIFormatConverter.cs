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
// Generated by IDLImporter from file nsIFormatConverter.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;

	
	
	/// <summary>nsIFormatConverter </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("948A0023-E3A7-11d2-96CF-0060B0FB9956")]
	public interface nsIFormatConverter
	{
		
		/// <summary>
        /// Get the list of the "input" data flavors (mime types as nsISupportsCString),
        /// in otherwords, the flavors that this converter can convert "from" (the
        /// incoming data to the converter).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetInputDataFlavors();
		
		/// <summary>
        /// Get the list of the "output" data flavors (mime types as nsISupportsCString),
        /// in otherwords, the flavors that this converter can convert "to" (the
        /// outgoing data to the converter).
        ///
        /// @param  aDataFlavorList fills list with supported flavors
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetOutputDataFlavors();
		
		/// <summary>
        /// Determines whether a conversion from one flavor to another is supported
        ///
        /// @param  aFromFormatConverter flavor to convert from
        /// @param  aFromFormatConverter flavor to convert to
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanConvert([MarshalAs(UnmanagedType.LPStr)] string aFromDataFlavor, [MarshalAs(UnmanagedType.LPStr)] string aToDataFlavor);
		
		/// <summary>
        /// Converts from one flavor to another.
        ///
        /// @param  aFromFormatConverter flavor to convert from
        /// @param  aFromFormatConverter flavor to convert to (destination own the memory)
        /// @returns returns NS_OK if it was converted
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Convert([MarshalAs(UnmanagedType.LPStr)] string aFromDataFlavor, [MarshalAs(UnmanagedType.Interface)] nsISupports aFromData, uint aDataLen, [MarshalAs(UnmanagedType.LPStr)] string aToDataFlavor, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aToData, ref uint aDataToLen);
	}
}
