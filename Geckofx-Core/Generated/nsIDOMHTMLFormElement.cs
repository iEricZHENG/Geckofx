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
// Generated by IDLImporter from file nsIDOMHTMLFormElement.idl
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
    /// The nsIDOMHTMLFormElement interface is the interface to a [X]HTML
    /// form element.
    ///
    /// This interface is trying to follow the DOM Level 2 HTML specification:
    /// http://www.w3.org/TR/DOM-Level-2-HTML/
    ///
    /// with changes from the work-in-progress WHATWG HTML specification:
    /// http://www.whatwg.org/specs/web-apps/current-work/
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ad9b2ad0-9d29-43f6-b1a2-a1fd24627e6b")]
	public interface nsIDOMHTMLFormElement
	{
		
		/// <summary>
        /// The nsIDOMHTMLFormElement interface is the interface to a [X]HTML
        /// form element.
        ///
        /// This interface is trying to follow the DOM Level 2 HTML specification:
        /// http://www.w3.org/TR/DOM-Level-2-HTML/
        ///
        /// with changes from the work-in-progress WHATWG HTML specification:
        /// http://www.whatwg.org/specs/web-apps/current-work/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAcceptCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAcceptCharset);
		
		/// <summary>
        /// The nsIDOMHTMLFormElement interface is the interface to a [X]HTML
        /// form element.
        ///
        /// This interface is trying to follow the DOM Level 2 HTML specification:
        /// http://www.w3.org/TR/DOM-Level-2-HTML/
        ///
        /// with changes from the work-in-progress WHATWG HTML specification:
        /// http://www.whatwg.org/specs/web-apps/current-work/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAcceptCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAcceptCharset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetActionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAction);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAction);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAutocompleteAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAutocomplete);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAutocompleteAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAutocomplete);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEnctypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEnctype);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnctypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEnctype);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEncodingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEncoding);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEncodingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEncoding);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMethod);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMethod);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetNoValidateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNoValidateAttribute([MarshalAs(UnmanagedType.U1)] bool aNoValidate);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTarget);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetElementsAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLengthAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Submit();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reset();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CheckValidity();
	}
}
