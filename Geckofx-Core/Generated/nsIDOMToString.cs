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
// Generated by IDLImporter from file nsIDOMToString.idl
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
    /// The sole purpose of this interface is to make it easy for XPCOM
    /// object's to hook into JS' toString() when interacting with
    /// XPConnect. If you implement this interface and advertize it in the
    /// object's classinfo, you'll get automatic mapping from JS'
    /// toString() to the toString() method in this interface.
    ///
    /// XXXjst: This doesn't really belong in dom/public/idl/storage, but
    /// it gets to live here until I find a more suitable place.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2a72e20f-e337-4822-8994-2e35b5550d03")]
	public interface nsIDOMToString
	{
		
		/// <summary>
        /// The sole purpose of this interface is to make it easy for XPCOM
        /// object's to hook into JS' toString() when interacting with
        /// XPConnect. If you implement this interface and advertize it in the
        /// object's classinfo, you'll get automatic mapping from JS'
        /// toString() to the toString() method in this interface.
        ///
        /// XXXjst: This doesn't really belong in dom/public/idl/storage, but
        /// it gets to live here until I find a more suitable place.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase retval);
	}
}
