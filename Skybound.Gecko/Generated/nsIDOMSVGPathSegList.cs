// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMSVGPathSegList.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMSVGPathSegList.idl
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
	
	
	/// <summary>nsIDOMSVGPathSegList </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("94a6db98-3f34-4529-a35f-89ef49713795")]
	public interface nsIDOMSVGPathSegList
	{
		
		/// <summary>Member GetNumberOfItemsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetNumberOfItemsAttribute();
		
		/// <summary>Member Clear </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
		
		/// <summary>Member Initialize </summary>
		/// <param name='newItem'> </param>
		/// <returns>A nsIDOMSVGPathSeg</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg Initialize([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPathSeg  newItem);
		
		/// <summary>Member GetItem </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGPathSeg</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg GetItem(System.UInt32  index);
		
		/// <summary>Member InsertItemBefore </summary>
		/// <param name='newItem'> </param>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGPathSeg</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg InsertItemBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPathSeg  newItem, System.UInt32  index);
		
		/// <summary>Member ReplaceItem </summary>
		/// <param name='newItem'> </param>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGPathSeg</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg ReplaceItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPathSeg  newItem, System.UInt32  index);
		
		/// <summary>Member RemoveItem </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGPathSeg</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg RemoveItem(System.UInt32  index);
		
		/// <summary>Member AppendItem </summary>
		/// <param name='newItem'> </param>
		/// <returns>A nsIDOMSVGPathSeg</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg AppendItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPathSeg  newItem);
	}
}