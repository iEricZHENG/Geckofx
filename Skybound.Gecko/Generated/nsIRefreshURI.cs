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
// Generated by IDLImporter from file nsIRefreshURI.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>nsIRefreshURI </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cb0ad623-6b46-4c09-a473-c1d6ca63d3c7")]
	public interface nsIRefreshURI
	{
		
		/// <summary>
        /// Load a uri after waiting for aMillis milliseconds. If the docshell
        /// is busy loading a page currently, the refresh request will be
        /// queued and executed when the current load finishes.
        ///
        /// @param aUri The uri to refresh.
        /// @param aMillis The number of milliseconds to wait.
        /// @param aRepeat Flag to indicate if the uri is to be
        /// repeatedly refreshed every aMillis milliseconds.
        /// @param aMetaRefresh Flag to indicate if this is a Meta refresh.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RefreshURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aMillis, [MarshalAs(UnmanagedType.Bool)] bool aRepeat, [MarshalAs(UnmanagedType.Bool)] bool aMetaRefresh);
		
		/// <summary>
        /// Loads a URI immediately as if it were a refresh.
        ///
        /// @param aURI The URI to refresh.
        /// @param aMillis The number of milliseconds by which this refresh would
        /// be delayed if it were not being forced.
        /// @param aMetaRefresh Flag to indicate if this is a meta refresh.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceRefreshURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aMillis, [MarshalAs(UnmanagedType.Bool)] bool aMetaRefresh);
		
		/// <summary>
        /// Checks the passed in channel to see if there is a refresh header,
        /// if there is, will setup a timer to refresh the uri found
        /// in the header. If docshell is busy loading a page currently, the
        /// request will be queued and executed when the current page
        /// finishes loading.
        ///
        /// Returns the NS_REFRESHURI_HEADER_FOUND success code if a refresh
        /// header was found and successfully setup.
        ///
        /// @param aChannel The channel to be parsed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupRefreshURI([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
		
		/// <summary>
        /// Parses the passed in header string and sets up a refreshURI if
        /// a "refresh" header is found. If docshell is busy loading a page
        /// currently, the request will be queued and executed when
        /// the current page finishes loading.
        ///
        /// @param aBaseURI base URI to resolve refresh uri with.
        /// @param aHeader  The meta refresh header string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupRefreshURIFromHeader([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeader);
		
		/// <summary>
        /// Cancels all timer loads.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelRefreshURITimers();
		
		/// <summary>
        /// True when there are pending refreshes, false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRefreshPendingAttribute();
	}
}
