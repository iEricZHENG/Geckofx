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
// Generated by IDLImporter from file nsIIDNService.idl
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

	
	
	/// <summary>
    /// nsIIDNService interface.
    ///
    /// IDN (Internationalized Domain Name) support. Provides facilities
    /// for manipulating IDN hostnames according to the specification set
    /// forth by the IETF.
    ///
    /// IDN effort:
    /// http://www.ietf.org/html.characters/idn-charter.html
    /// http://www.i-dns.net
    ///
    /// IDNA specification:
    /// http://search.ietf.org/internet-drafts/draft-ietf-idn-idna-06.txt
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a592a60e-3621-4f19-a318-2bf233cfad3e")]
	public interface nsIIDNService
	{
		
		/// <summary>
        /// Prepares the input hostname according to IDNA ToASCII operation,
        /// the input hostname is assumed to be UTF8-encoded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertUTF8toACE([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase input, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// This is the ToUnicode operation as specified in the IDNA proposal,
        /// with an additional step to encode the result in UTF-8.
        /// It takes an ACE-encoded hostname and performs ToUnicode to it, then
        /// encodes the resulting string into UTF8.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertACEtoUTF8([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase input, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Checks if the input string is ACE encoded or not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsACE([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase input);
		
		/// <summary>
        /// Performs the unicode normalization needed for hostnames in IDN,
        /// for callers that want early normalization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Normalize([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase input, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Normalizes and converts a host to UTF-8 if the host is in the IDN
        /// whitelist, otherwise converts it to ACE. This is useful for display
        /// purposes and to ensure an encoding consistent with nsIURI::GetHost().
        /// If the result is ASCII or ACE encoded, |isASCII| will be true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertToDisplayIDN([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase input, [MarshalAs(UnmanagedType.U1)] ref bool isASCII, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
	}
}
