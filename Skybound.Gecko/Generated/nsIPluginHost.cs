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
// Generated by IDLImporter from file nsIPluginHost.idl
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
	
	
	/// <summary>nsIPluginHost </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("28F1F9E1-CD23-4FE2-BCC8-BBB0B2D49A4A")]
	public interface nsIPluginHost
	{
		
		/// <summary>
        /// Causes the plugins directory to be searched again for new plugin
        /// libraries.
        ///
        /// @param reloadPages - indicates whether currently visible pages should
        /// also be reloaded
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReloadPlugins([MarshalAs(UnmanagedType.Bool)] bool reloadPages);
		
		/// <summary>Member GetPluginTags </summary>
		/// <param name='aPluginCount'> </param>
		/// <param name='aResults'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPluginTags(ref uint aPluginCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref nsIPluginTag[] aResults);
		
		/// <summary>
        /// Clear site data for a given plugin.
        ///
        /// @param plugin: the plugin to clear data for, such as one returned by
        /// nsIPluginHost.getPluginTags.
        /// @param domain: the domain to clear data for. If this argument is null,
        /// clear data for all domains. Otherwise, it must be a domain
        /// only (not a complete URI or IRI). The base domain for the
        /// given site will be determined; any data for the base domain
        /// or its subdomains will be cleared.
        /// @param flags: a flag value defined above.
        /// @param maxAge: the maximum age in seconds of data to clear, inclusive. If
        /// maxAge is 0, no data is cleared; if it is -1, all data is
        /// cleared.
        ///
        /// @throws NS_ERROR_INVALID_ARG if the domain argument is malformed.
        /// @throws NS_ERROR_PLUGIN_TIME_RANGE_NOT_SUPPORTED if maxAge is a value other
        /// than -1 and the plugin does not support clearing by timerange in
        /// general or for that particular site and/or flag combination.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearSiteData([MarshalAs(UnmanagedType.Interface)] nsIPluginTag plugin, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String domain, ulong flags, long maxAge);
		
		/// <summary>
        /// Determine if a plugin has stored data for a given site.
        ///
        /// @param plugin: the plugin to query, such as one returned by
        /// nsIPluginHost.getPluginTags.
        /// @param domain: the domain to test. If this argument is null, test if data
        /// is stored for any site. The base domain for the given domain
        /// will be determined; if any data for the base domain or its
        /// subdomains is found, return true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SiteHasData([MarshalAs(UnmanagedType.Interface)] nsIPluginTag plugin, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String domain);
	}
}
