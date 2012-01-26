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
// Generated by IDLImporter from file nsIApplicationCacheService.idl
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
	
	
	/// <summary>
    /// The application cache service manages the set of application cache
    /// groups.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("611161c8-37d0-450f-a4fe-457c47bbaf64")]
	public interface nsIApplicationCacheService
	{
		
		/// <summary>
        /// Create a new, empty application cache for the given cache
        /// group.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIApplicationCache CreateApplicationCache([MarshalAs(UnmanagedType.LPStruct)] nsACString group);
		
		/// <summary>
        /// Get an application cache object for the given client ID.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIApplicationCache GetApplicationCache([MarshalAs(UnmanagedType.LPStruct)] nsACString clientID);
		
		/// <summary>
        /// Get the currently active cache object for a cache group.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIApplicationCache GetActiveCache([MarshalAs(UnmanagedType.LPStruct)] nsACString group);
		
		/// <summary>
        /// Deactivate the currently-active cache object for a cache group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeactivateGroup([MarshalAs(UnmanagedType.LPStruct)] nsACString group);
		
		/// <summary>
        /// Try to find the best application cache to serve a resource.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIApplicationCache ChooseApplicationCache([MarshalAs(UnmanagedType.LPStruct)] nsACString key);
		
		/// <summary>
        /// Flags the key as being opportunistically cached.
        ///
        /// This method should also propagate the entry to other
        /// application caches with the same opportunistic namespace, but
        /// this is not currently implemented.
        ///
        /// @param cache
        /// The cache in which the entry is cached now.
        /// @param key
        /// The cache entry key.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CacheOpportunistically([MarshalAs(UnmanagedType.Interface)] nsIApplicationCache cache, [MarshalAs(UnmanagedType.LPStruct)] nsACString key);
		
		/// <summary>
        /// Get the list of application cache groups.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGroups(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] groupIDs);
	}
}
