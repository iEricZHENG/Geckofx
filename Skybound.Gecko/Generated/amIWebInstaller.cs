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
// Generated by IDLImporter from file amIWebInstaller.idl
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
    /// This interface is used to allow webpages to start installing add-ons.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4fdf4f84-73dc-4857-9bbe-84895e8afd5d")]
	public interface amIWebInstaller
	{
		
		/// <summary>
        /// Checks if installation is enabled for a webpage.
        ///
        /// @param  aMimetype
        /// The mimetype for the add-on to be installed
        /// @param  referer
        /// The URL of the webpage trying to install an add-on
        /// @return true if installation is enabled
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsInstallEnabled([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMimetype, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferer);
		
		/// <summary>
        /// Installs an array of add-ons at the request of a webpage
        ///
        /// @param  aMimetype
        /// The mimetype for the add-ons
        /// @param  aWindow
        /// The window installing the add-ons
        /// @param  aReferer
        /// The URI for the webpage installing the add-ons
        /// @param  aUris
        /// The URIs of add-ons to be installed
        /// @param  aHashes
        /// The hashes for the add-ons to be installed
        /// @param  aNames
        /// The names for the add-ons to be installed
        /// @param  aIcons
        /// The icons for the add-ons to be installed
        /// @param  aCallback
        /// An optional callback to notify about installation success and
        /// failure
        /// @param  aInstallCount
        /// An optional argument including the number of add-ons to install
        /// @return true if the installation was successfully started
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool InstallAddonsFromWebpage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMimetype, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferer, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] System.IntPtr[] aUris, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] System.IntPtr[] aHashes, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] System.IntPtr[] aNames, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] System.IntPtr[] aIcons, amIInstallCallback aCallback, uint aInstallCount);
	}
}
