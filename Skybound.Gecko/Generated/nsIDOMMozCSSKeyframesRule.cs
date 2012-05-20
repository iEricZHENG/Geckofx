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
// Generated by IDLImporter from file nsIDOMMozCSSKeyframesRule.idl
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
	
	
	/// <summary>nsIDOMMozCSSKeyframesRule </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("aa4ea11f-791b-4671-b192-b931e6539669")]
	public interface nsIDOMMozCSSKeyframesRule : nsIDOMCSSRule
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>Member GetCssTextAttribute </summary>
		/// <param name='aCssText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCssTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCssText);
		
		/// <summary>Member SetCssTextAttribute </summary>
		/// <param name='aCssText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCssTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCssText);
		
		/// <summary>
        /// raises(DOMException) on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCSSStyleSheet GetParentStyleSheetAttribute();
		
		/// <summary>Member GetParentRuleAttribute </summary>
		/// <returns>A nsIDOMCSSRule</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCSSRule GetParentRuleAttribute();
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>Member GetCssRulesAttribute </summary>
		/// <returns>A nsIDOMCSSRuleList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRuleList GetCssRulesAttribute();
		
		/// <summary>Member InsertRule </summary>
		/// <param name='rule'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertRule([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase rule);
		
		/// <summary>Member DeleteRule </summary>
		/// <param name='key'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteRule([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key);
		
		/// <summary>Member FindRule </summary>
		/// <param name='key'> </param>
		/// <returns>A nsIDOMMozCSSKeyframeRule</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMozCSSKeyframeRule FindRule([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key);
	}
}
