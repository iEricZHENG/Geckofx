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
// Generated by IDLImporter from file nsIDOMDOMSettableTokenList.idl
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
    /// The DOMSettableTokenList interface is the same as the DOMTokenList interface,
    /// except that it allows the underlying string to be directly changed.
    ///
    /// For more information on this interface please see:
    /// http://dev.w3.org/html5/spec/infrastructure.html#domsettabletokenlist
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cdac274e-6619-4b5f-ba1a-cd1dbfae44b8")]
	public interface nsIDOMDOMSettableTokenList : nsIDOMDOMTokenList
	{
		
		/// <summary>
        /// The DOMTokenList interface represents an interface to an underlying string
        /// that consists of a set of space-separated tokens.
        ///
        /// For more information on this interface please see
        /// <http://www.whatwg.org/html5/#domtokenlist>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetLengthAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Item(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Contains([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase token);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Add([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase token);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Remove([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase token);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Toggle([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase token);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// The DOMSettableTokenList interface is the same as the DOMTokenList interface,
        /// except that it allows the underlying string to be directly changed.
        ///
        /// For more information on this interface please see:
        /// http://dev.w3.org/html5/spec/infrastructure.html#domsettabletokenlist
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>
        /// The DOMSettableTokenList interface is the same as the DOMTokenList interface,
        /// except that it allows the underlying string to be directly changed.
        ///
        /// For more information on this interface please see:
        /// http://dev.w3.org/html5/spec/infrastructure.html#domsettabletokenlist
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
	}
}
