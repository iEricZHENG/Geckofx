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
// Generated by IDLImporter from file nsIDOMStorage.idl
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
    /// Interface for client side storage. See
    /// http://www.whatwg.org/specs/web-apps/current-work/multipage/structured.html#storage0
    /// for more information.
    ///
    /// A storage object stores an arbitrary set of key-value pairs, which
    /// may be retrieved, modified and removed as needed. A key may only
    /// exist once within a storage object, and only one value may be
    /// associated with a particular key. Keys are stored in a particular
    /// order with the condition that this order not change by merely changing
    /// the value associated with a key, but the order may change when a
    /// key is added or removed.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("43E5EDAD-1E02-42c4-9D99-C3D9DEE22A20")]
	public interface nsIDOMStorage
	{
		
		/// <summary>
        /// The number of keys stored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLengthAttribute();
		
		/// <summary>
        /// Retrieve the name of the key at a particular index.
        ///
        /// @param index index of the item to retrieve
        /// @returns the key at index
        /// @throws INDEX_SIZE_ERR if there is no key at that index
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Key(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Retrieve an item with a given key
        ///
        /// @param key key to retrieve
        /// @returns found data or empty string if the key was not found
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItem([MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Assign a value with a key. If the key does not exist already, a new
        /// key is added associated with that value. If the key already exists,
        /// then the existing value is replaced with a new value.
        ///
        /// @param key key to set
        /// @param data data to associate with the key
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItem([MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>
        /// Remove a key and its corresponding value.
        ///
        /// @param key key to remove
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItem([MarshalAs(UnmanagedType.LPStruct)] nsAString key);
		
		/// <summary>
        /// Clear the content of this storage bound to a domain
        /// or an origin.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
	}
}
