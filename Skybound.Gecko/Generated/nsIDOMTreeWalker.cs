// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMTreeWalker.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMTreeWalker.idl
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
	
	
	/// <summary>nsIDOMTreeWalker </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("400af3ca-1dd2-11b2-a50a-887ecca2e63a")]
	public interface nsIDOMTreeWalker
	{
		
		/// <summary>Member GetRootAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetRootAttribute();
		
		/// <summary>Member GetWhatToShowAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetWhatToShowAttribute();
		
		/// <summary>Member GetFilterAttribute </summary>
		/// <returns>A nsIDOMNodeFilter </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeFilter  GetFilterAttribute();
		
		/// <summary>Member GetExpandEntityReferencesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetExpandEntityReferencesAttribute();
		
		/// <summary>Member GetCurrentNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetCurrentNodeAttribute();
		
		/// <summary>Member SetCurrentNodeAttribute </summary>
		/// <param name='aCurrentNode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentNodeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aCurrentNode);
		
		/// <summary>Member ParentNode </summary>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ParentNode();
		
		/// <summary>Member FirstChild </summary>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode FirstChild();
		
		/// <summary>Member LastChild </summary>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode LastChild();
		
		/// <summary>Member PreviousSibling </summary>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode PreviousSibling();
		
		/// <summary>Member NextSibling </summary>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode NextSibling();
		
		/// <summary>Member PreviousNode </summary>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode PreviousNode();
		
		/// <summary>Member NextNode </summary>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode NextNode();
	}
}