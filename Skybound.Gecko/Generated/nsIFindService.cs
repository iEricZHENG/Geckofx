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
// Generated by IDLImporter from file nsIFindService.idl
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
	
	
	/// <summary>nsIFindService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5060b801-340e-11d5-be5b-b3e063ec6a3c")]
	public interface nsIFindService
	{
		
		/// <summary>
        /// The sole purpose of the Find service is to store globally the
        /// last used Find settings
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSearchString);
		
		/// <summary>
        /// The sole purpose of the Find service is to store globally the
        /// last used Find settings
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSearchString);
		
		/// <summary>Member GetReplaceStringAttribute </summary>
		/// <param name='aReplaceString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReplaceStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReplaceString);
		
		/// <summary>Member SetReplaceStringAttribute </summary>
		/// <param name='aReplaceString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReplaceStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReplaceString);
		
		/// <summary>Member GetFindBackwardsAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFindBackwardsAttribute();
		
		/// <summary>Member SetFindBackwardsAttribute </summary>
		/// <param name='aFindBackwards'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFindBackwardsAttribute([MarshalAs(UnmanagedType.Bool)] bool aFindBackwards);
		
		/// <summary>Member GetWrapFindAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetWrapFindAttribute();
		
		/// <summary>Member SetWrapFindAttribute </summary>
		/// <param name='aWrapFind'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWrapFindAttribute([MarshalAs(UnmanagedType.Bool)] bool aWrapFind);
		
		/// <summary>Member GetEntireWordAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEntireWordAttribute();
		
		/// <summary>Member SetEntireWordAttribute </summary>
		/// <param name='aEntireWord'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEntireWordAttribute([MarshalAs(UnmanagedType.Bool)] bool aEntireWord);
		
		/// <summary>Member GetMatchCaseAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMatchCaseAttribute();
		
		/// <summary>Member SetMatchCaseAttribute </summary>
		/// <param name='aMatchCase'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMatchCaseAttribute([MarshalAs(UnmanagedType.Bool)] bool aMatchCase);
	}
}
