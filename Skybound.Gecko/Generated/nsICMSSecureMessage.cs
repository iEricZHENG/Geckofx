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
// Generated by IDLImporter from file nsICMSSecureMessage.idl
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
    /// nsICMSManager (service)
    /// Interface to access users certificate store
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("14b4394a-1dd2-11b2-b4fd-ba4a194fe97e")]
	public interface nsICMSSecureMessage
	{
		
		/// <summary>
        /// getCertByPrefID - a BASE64 string representing a user's
        /// certificate (or NULL if there isn't one)
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCertByPrefID([MarshalAs(UnmanagedType.LPStr)] string certID);
		
		/// <summary>
        /// decodeCert - decode a BASE64 string into an X509Certificate object
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509Cert DecodeCert([MarshalAs(UnmanagedType.LPStr)] string value);
		
		/// <summary>
        /// sendMessage - send a text message to the recipient indicated
        /// by the base64-encoded cert.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string SendMessage([MarshalAs(UnmanagedType.LPStr)] string msg, [MarshalAs(UnmanagedType.LPStr)] string cert);
		
		/// <summary>
        /// receiveMessage - receive an encrypted (enveloped) message
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ReceiveMessage([MarshalAs(UnmanagedType.LPStr)] string msg);
	}
}
