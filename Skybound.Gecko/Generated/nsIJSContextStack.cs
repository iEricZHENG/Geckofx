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
// Generated by IDLImporter from file nsIJSContextStack.idl
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
	
	
	/// <summary>nsIJSContextStack </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c67d8270-3189-11d3-9885-006008962422")]
	public interface nsIJSContextStack
	{
		
		/// <summary>Member GetCountAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCountAttribute();
		
		/// <summary>Member Peek </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Peek();
		
		/// <summary>Member Pop </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Pop();
		
		/// <summary>Member Push </summary>
		/// <param name='cx'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Push(System.IntPtr cx);
	}
	
	/// <summary>nsIJSContextStackIterator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c7e6b7aa-fc12-4ca7-b140-98c38b698961")]
	public interface nsIJSContextStackIterator
	{
		
		/// <summary>
        /// Resets this iterator to the beginning of this thread's stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reset([MarshalAs(UnmanagedType.Interface)] nsIJSContextStack stack);
		
		/// <summary>
        /// Returns true if this iterator is at the end of its stack's contexts.
        /// @throws NS_ERROR_NOT_INITIALIZED If there has not been a previous call
        /// to reset.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Done();
		
		/// <summary>
        /// Returns the prev JSContext off of stack. Note that because we're
        /// iterating over a stack, this value would be the next popped value.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED If there has not been a previous call
        /// to reset.
        /// @throws NS_ERROR_NOT_AVAILABLE if already at the end.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Prev();
	}
	
	/// <summary>nsIThreadJSContextStack </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b7056a2a-a02d-43b1-abb9-47f81f8bf258")]
	public interface nsIThreadJSContextStack : nsIJSContextStack
	{
		
		/// <summary>Member GetCountAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetCountAttribute();
		
		/// <summary>Member Peek </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr Peek();
		
		/// <summary>Member Pop </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr Pop();
		
		/// <summary>Member Push </summary>
		/// <param name='cx'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Push(System.IntPtr cx);
		
		/// <summary>
        ///inherits methods of nsIJSContextStack </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSafeJSContextAttribute();
	}
}
