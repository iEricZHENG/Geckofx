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
// Generated by IDLImporter from file nsIMutable.idl
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
    /// nsIMutable defines an interface to be implemented by objects which
    /// can be made immutable.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("321578d0-03c1-4d95-8821-021ac612d18d")]
	public interface nsIMutable
	{
		
		/// <summary>
        /// Control whether or not this object can be modified.  If the flag is
        /// false, no modification is allowed.  Once the flag has been set to false,
        /// it cannot be reset back to true -- attempts to do so throw
        /// NS_ERROR_INVALID_ARG.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMutableAttribute();
		
		/// <summary>
        /// Control whether or not this object can be modified.  If the flag is
        /// false, no modification is allowed.  Once the flag has been set to false,
        /// it cannot be reset back to true -- attempts to do so throw
        /// NS_ERROR_INVALID_ARG.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMutableAttribute([MarshalAs(UnmanagedType.Bool)] bool aMutable);
	}
}
