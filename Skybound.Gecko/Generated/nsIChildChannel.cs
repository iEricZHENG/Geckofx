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
// Generated by IDLImporter from file nsIChildChannel.idl
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
    /// Implemented by content side of IPC protocols.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c45b92ae-4f07-41dd-b0ef-aa044eeabb1e")]
	public interface nsIChildChannel
	{
		
		/// <summary>
        /// Create the chrome side of the IPC protocol and join an existing 'real'
        /// channel on the parent process.  The id is provided by
        /// nsIRedirectChannelRegistrar on the chrome process and pushed to the child
        /// protocol as an argument to event starting a redirect.
        ///
        /// Primarilly used in HttpChannelChild::Redirect1Begin on a newly created
        /// child channel, where the new channel is intended to be created on the
        /// child process.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConnectParent(uint id);
		
		/// <summary>
        /// As AsyncOpen is called on the chrome process for redirect target channels,
        /// we have to inform the child side of the protocol of that fact by a special
        /// method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CompleteRedirectSetup([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
	}
}
