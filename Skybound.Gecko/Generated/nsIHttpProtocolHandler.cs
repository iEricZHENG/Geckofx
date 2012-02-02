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
// Generated by IDLImporter from file nsIHttpProtocolHandler.idl
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
	
	
	/// <summary>nsIHttpProtocolHandler </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9814fdf0-5ac3-11e0-80e3-0800200c9a66")]
	public interface nsIHttpProtocolHandler : nsIProxiedProtocolHandler
	{
		
		/// <summary>
        /// The scheme of this protocol (e.g., "file").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);
		
		/// <summary>
        /// The default port is the port that this protocol normally uses.
        /// If a port does not make sense for the protocol (e.g., "about:")
        /// then -1 will be returned.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetDefaultPortAttribute();
		
		/// <summary>
        /// Returns the protocol specific flags (see flag definitions below).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetProtocolFlagsAttribute();
		
		/// <summary>
        /// Makes a URI object that is suitable for loading by this protocol,
        /// where the URI string is given as an UTF-8 string.  The caller may
        /// provide the charset from which the URI string originated, so that
        /// the URI string can be translated back to that charset (if necessary)
        /// before communicating with, for example, the origin server of the URI
        /// string.  (Many servers do not support UTF-8 IRIs at the present time,
        /// so we must be careful about tracking the native charset of the origin
        /// server.)
        ///
        /// @param aSpec          - the URI string in UTF-8 encoding. depending
        /// on the protocol implementation, unicode character
        /// sequences may or may not be %xx escaped.
        /// @param aOriginCharset - the charset of the document from which this URI
        /// string originated.  this corresponds to the
        /// charset that should be used when communicating
        /// this URI to an origin server, for example.  if
        /// null, then UTF-8 encoding is assumed (i.e.,
        /// no charset transformation from aSpec).
        /// @param aBaseURI       - if null, aSpec must specify an absolute URI.
        /// otherwise, aSpec may be resolved relative
        /// to aBaseURI, depending on the protocol.
        /// If the protocol has no concept of relative
        /// URI aBaseURI will simply be ignored.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// Constructs a new channel from the given URI for this protocol handler.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIChannel NewChannel([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Allows a protocol to override blacklisted ports.
        ///
        /// This method will be called when there is an attempt to connect to a port
        /// that is blacklisted.  For example, for most protocols, port 25 (Simple Mail
        /// Transfer) is banned.  When a URI containing this "known-to-do-bad-things"
        /// port number is encountered, this function will be called to ask if the
        /// protocol handler wants to override the ban.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool AllowPort(int port, [MarshalAs(UnmanagedType.LPStr)] string scheme);
		
		/// <summary>
        ///Create a new channel with the given proxyInfo
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIChannel NewProxiedChannel([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo proxyInfo);
		
		/// <summary>
        /// Get the HTTP advertised user agent string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUserAgentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUserAgent);
		
		/// <summary>
        /// Get the application name.
        ///
        /// @return The name of this application (eg. "Mozilla").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAppName);
		
		/// <summary>
        /// Get the application version string.
        ///
        /// @return The complete version (major and minor) string. (eg. "5.0")
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAppVersion);
		
		/// <summary>
        /// @return The product name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProductAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProduct);
		
		/// <summary>
        /// @return A product sub string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProductSubAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProductSub);
		
		/// <summary>
        /// Get the current platform.
        ///
        /// @return The platform this application is running on
        /// (eg. "Windows", "Macintosh", "X11")
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPlatform);
		
		/// <summary>
        /// Get the current oscpu.
        ///
        /// @return The oscpu this application is running on
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOscpuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOscpu);
		
		/// <summary>
        /// Get the application comment misc portion.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMiscAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMisc);
	}
}
