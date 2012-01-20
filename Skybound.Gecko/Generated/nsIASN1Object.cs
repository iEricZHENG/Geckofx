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
// Generated by IDLImporter from file nsIASN1Object.idl
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
    /// This represents an ASN.1 object,
    /// where ASN.1 is "Abstract Syntax Notation number One".
    ///
    /// The additional state information carried in this interface
    /// makes it fit for being used as the data structure
    /// when working with visual reprenstation of ASN.1 objects
    /// in a human user interface, like in a tree widget
    /// where open/close state of nodes must be remembered.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ba8bf582-1dd1-11b2-898c-f40246bc9a63")]
	public interface nsIASN1Object
	{
		
		/// <summary>
        /// "type" will be equal to one of the defined object identifiers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTypeAttribute();
		
		/// <summary>
        /// "type" will be equal to one of the defined object identifiers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute(uint aType);
		
		/// <summary>
        /// This contains a tag as explained in ASN.1 standards documents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTagAttribute();
		
		/// <summary>
        /// This contains a tag as explained in ASN.1 standards documents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTagAttribute(uint aTag);
		
		/// <summary>
        /// "displayName" contains a human readable explanatory label.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayName);
		
		/// <summary>
        /// "displayName" contains a human readable explanatory label.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayName);
		
		/// <summary>
        /// "displayValue" contains the human readable value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayValue);
		
		/// <summary>
        /// "displayValue" contains the human readable value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayValue);
	}
}
