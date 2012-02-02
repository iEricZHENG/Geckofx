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
// Generated by IDLImporter from file nsICapturePicker.idl
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
	
	
	/// <summary>nsICapturePicker </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a4e2b2de-5712-4f80-aabb-7de3a747f227")]
	public interface nsICapturePicker
	{
		
		/// <summary>
        /// Initialize the camera picker widget.  The camera picker is not valid until this
        /// method is called.
        ///
        /// @param      parent     nsIDOMWindow parent.  This dialog will be dependent
        /// on this parent.  This must not be null.
        /// @param      title      The title for the file widget
        /// @param      flags      Mode and type flags for what to capture
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase title, uint mode);
		
		/// <summary>
        /// Show file dialog.  The dialog is displayed modally.
        ///
        /// @return returnOK if the user captures the requested content, returnCancel if
        /// the user cancels the capture process
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Show();
		
		/// <summary>
        /// Determine if the given mode might be available.  Consumers should take a
        /// true value to be a hint of what might be available, not a guarantee.
        ///
        /// @param      mode       Mode to examine
        ///
        /// @return false if the requested mode can definitely not be captured,
        /// true otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ModeMayBeAvailable(uint mode);
		
		/// <summary>
        /// Get the captured image/video/audio.  This may be a data URI, file URI,
        /// or a moz-filedata reference URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMFile GetFileAttribute();
		
		/// <summary>
        /// The MIME type of the captured content.  Cannot be set after calling show()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// The MIME type of the captured content.  Cannot be set after calling show()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
	}
}
