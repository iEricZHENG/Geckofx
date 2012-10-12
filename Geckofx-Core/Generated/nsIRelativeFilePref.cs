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
// Generated by IDLImporter from file nsIRelativeFilePref.idl
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
    /// The nsIRelativeFilePref interface is a wrapper for an nsILocalFile and
    /// and a directory service key. When used as a pref value, it stores a
    /// relative path to the file from the location pointed to by the directory
    /// service key. The path has the same syntax across all platforms.
    ///
    /// @see nsIPrefBranch::getComplexValue
    /// @see nsIPrefBranch::setComplexValue
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2f977d4e-5485-11d4-87e2-0010a4e75ef2")]
	public interface nsIRelativeFilePref
	{
		
		/// <summary>
        /// file
        ///
        /// The file whose location is stored or retrieved.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetFileAttribute();
		
		/// <summary>
        /// file
        ///
        /// The file whose location is stored or retrieved.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileAttribute([MarshalAs(UnmanagedType.Interface)] nsILocalFile aFile);
		
		/// <summary>
        /// relativeToKey
        ///
        /// A directory service key for the directory
        /// from which the file path is relative.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRelativeToKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRelativeToKey);
		
		/// <summary>
        /// relativeToKey
        ///
        /// A directory service key for the directory
        /// from which the file path is relative.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRelativeToKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRelativeToKey);
	}
}
