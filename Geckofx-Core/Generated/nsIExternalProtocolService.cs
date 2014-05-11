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
// Generated by IDLImporter from file nsIExternalProtocolService.idl
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
    /// The external protocol service is used for finding and launching
    /// web handlers (a la registerProtocolHandler in the HTML5 draft) or
    /// platform-specific applications for handling particular protocols.
    ///
    /// You can ask the external protocol service if it has an external
    /// handler for a given protocol scheme. And you can ask it to load
    /// the url using the default handler.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("70f93b7a-3ec6-4bcb-b093-92d9984c9f83")]
	public interface nsIExternalProtocolService
	{
		
		/// <summary>
        /// Check whether a handler for a specific protocol exists.  Specifically,
        /// this looks to see whether there are any known possible application handlers
        /// in either the nsIHandlerService datastore or registered with the OS.
        ///
        /// @param aProtocolScheme The scheme from a url: http, ftp, mailto, etc.
        ///
        /// @return true if we have a handler and false otherwise.
        ///
        /// XXX shouldn't aProtocolScheme be an ACString like nsIURI::scheme?
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ExternalProtocolHandlerExists([MarshalAs(UnmanagedType.LPStr)] string aProtocolScheme);
		
		/// <summary>
        /// Check whether a handler for a specific protocol is "exposed" as a visible
        /// feature of the current application.
        ///
        /// An exposed protocol handler is one that can be used in all contexts.  A
        /// non-exposed protocol handler is one that can only be used internally by the
        /// application.  For example, a non-exposed protocol would not be loaded by the
        /// application in response to a link click or a X-remote openURL command.
        /// Instead, it would be deferred to the system's external protocol handler.
        /// XXX shouldn't aProtocolScheme be an ACString like nsIURI::scheme?
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsExposedProtocol([MarshalAs(UnmanagedType.LPStr)] string aProtocolScheme);
		
		/// <summary>
        /// Retrieve the handler for the given protocol.  If neither the application
        /// nor the OS knows about a handler for the protocol, the object this method
        /// returns will represent a default handler for unknown content.
        ///
        /// @param aProtocolScheme the scheme from a URL: http, ftp, mailto, etc.
        ///
        /// Note: aProtocolScheme should not include a trailing colon, which is part
        /// of the URI syntax, not part of the scheme itself (i.e. pass "mailto" not
        /// "mailto:").
        ///
        /// @return the handler, if any; otherwise a default handler
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIHandlerInfo GetProtocolHandlerInfo([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocolScheme);
		
		/// <summary>
        /// Given a scheme, looks up the protocol info from the OS.  This should be
        /// overridden by each OS's implementation.
        ///
        /// @param aScheme The protocol scheme we are looking for.
        /// @param aFound  Was an OS default handler for this scheme found?
        /// @return An nsIHanderInfo for the protocol.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIHandlerInfo GetProtocolHandlerInfoFromOS([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocolScheme, [MarshalAs(UnmanagedType.U1)] ref bool aFound);
		
		/// <summary>
        /// Set some sane defaults for a protocol handler object.
        ///
        /// @param aHandlerInfo      nsIHandlerInfo object, as returned by
        /// getProtocolHandlerInfoFromOS
        /// @param aOSHandlerExists  was the object above created for an extant
        /// OS default handler?  This is generally the
        /// value of the aFound out param from
        /// getProtocolHandlerInfoFromOS.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProtocolHandlerDefaults([MarshalAs(UnmanagedType.Interface)] nsIHandlerInfo aHandlerInfo, [MarshalAs(UnmanagedType.U1)] bool aOSHandlerExists);
		
		/// <summary>
        /// Used to load a url via an external protocol handler (if one exists)
        ///
        /// @param aURL The url to load
        ///
        /// @deprecated Use LoadURI instead (See Bug 389565 for removal)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadUrl([MarshalAs(UnmanagedType.Interface)] nsIURI aURL);
		
		/// <summary>
        /// Used to load a URI via an external application. Might prompt the user for
        /// permission to load the external application.
        ///
        /// @param aURI
        /// The URI to load
        ///
        /// @param aWindowContext
        /// The window to parent the dialog against, and, if a web handler
        /// is chosen, it is loaded in this window as well.  This parameter
        /// may be ultimately passed nsIURILoader.openURI in the case of a
        /// web handler, and aWindowContext is null or not present, web
        /// handlers will fail.  We need to do better than that; bug 394483
        /// filed in order to track.
        ///
        /// @note  Embedders that do not expose the http protocol should not currently
        /// use web-based protocol handlers, as handoff won't work correctly
        /// (bug 394479).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);
		
		/// <summary>
        /// Gets a human-readable description for the application responsible for
        /// handling a specific protocol.
        ///
        /// @param aScheme The scheme to look up. For example, "mms".
        ///
        /// @throw NS_ERROR_NOT_IMPLEMENTED
        /// If getting descriptions for protocol helpers is not supported
        /// @throw NS_ERROR_NOT_AVAILABLE
        /// If no protocol helper exists for this scheme, or if it is not
        /// possible to get a description for it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetApplicationDescription([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aScheme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase retval);
	}
}
