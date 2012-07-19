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
// Generated by IDLImporter from file nsISessionStartup.idl
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
    /// nsISessionStore keeps track of the current browsing state - i.e.
    /// tab history, cookies, scroll state, form data, POSTDATA and window features
    /// - and allows to restore everything into one window.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("170c6857-7f71-46ce-bc9b-185723b1c3a8")]
	public interface nsISessionStartup
	{
		
		/// <summary>
        /// Get session state
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetStateAttribute();
		
		/// <summary>
        /// Determine if session should be restored
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DoRestore();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSessionTypeAttribute();
	}
	
	/// <summary>nsISessionStartupConsts </summary>
	public class nsISessionStartupConsts
	{
		
		// <summary>
        // What type of session we're restoring.
        // NO_SESSION       There is no data available from the previous session
        // RECOVER_SESSION  The last session crashed. It will either be restored or
        // about:sessionrestore will be shown.
        // RESUME_SESSION   The previous session should be restored at startup
        // DEFER_SESSION    The previous session is fine, but it shouldn't be restored
        // without explicit action (with the exception of pinned tabs)
        // </summary>
		public const ulong NO_SESSION = 0;
		
		// 
		public const ulong RECOVER_SESSION = 1;
		
		// 
		public const ulong RESUME_SESSION = 2;
		
		// 
		public const ulong DEFER_SESSION = 3;
	}
}
