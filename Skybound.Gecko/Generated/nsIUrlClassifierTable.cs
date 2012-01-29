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
// Generated by IDLImporter from file nsIUrlClassifierTable.idl
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
    /// A map that contains a string keys mapped to string values.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fd1f8334-1859-472d-b01f-4ac6b1121ce4")]
	public interface nsIUrlClassifierTable
	{
		
		/// <summary>
        /// The name used to identify this table
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aName);
		
		/// <summary>
        /// The name used to identify this table
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aName);
		
		/// <summary>
        /// Set to false if we don't want to update this table.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetNeedsUpdateAttribute();
		
		/// <summary>
        /// Set to false if we don't want to update this table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNeedsUpdateAttribute([MarshalAs(UnmanagedType.U1)] bool aNeedsUpdate);
		
		/// <summary>
        /// In the simple case, exists just looks up the string in the
        /// table and call the callback after the query returns with true or
        /// false.  It's possible that something more complex happens
        /// (e.g., canonicalize the url).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Exists([MarshalAs(UnmanagedType.LPStruct)] nsACString key, [MarshalAs(UnmanagedType.Interface)] nsIUrlListManagerCallback cb);
	}
}
