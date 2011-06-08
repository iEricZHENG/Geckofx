// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMNodeSelector.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMNodeSelector.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIDOMNodeSelector </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7cebc153-168a-416c-ba5a-56a8c2ddb2ec")]
	public interface nsIDOMNodeSelector
	{
		
		/// <summary>Member QuerySelector </summary>
		/// <param name='selectors'> </param>
		/// <returns>A nsIDOMElement</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement QuerySelector([MarshalAs(UnmanagedType.LPStruct)] nsAString selectors);
		
		/// <summary>Member QuerySelectorAll </summary>
		/// <param name='selectors'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList QuerySelectorAll([MarshalAs(UnmanagedType.LPStruct)] nsAString selectors);
	}
}