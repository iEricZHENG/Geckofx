// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDragSession.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDragSession.idl
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
	
	
	/// <summary>nsIDragSession </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fde41f6a-c710-46f8-a0a8-1ff76ca4ff57")]
	public interface nsIDragSession
	{
		
		/// <summary>Member GetCanDropAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetCanDropAttribute();
		
		/// <summary>Member SetCanDropAttribute </summary>
		/// <param name='aCanDrop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCanDropAttribute(System.Boolean  aCanDrop);
		
		/// <summary>Member GetOnlyChromeDropAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetOnlyChromeDropAttribute();
		
		/// <summary>Member SetOnlyChromeDropAttribute </summary>
		/// <param name='aOnlyChromeDrop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnlyChromeDropAttribute(System.Boolean  aOnlyChromeDrop);
		
		/// <summary>Member GetDragActionAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetDragActionAttribute();
		
		/// <summary>Member SetDragActionAttribute </summary>
		/// <param name='aDragAction'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDragActionAttribute(System.UInt32  aDragAction);
		
		/// <summary>Member GetTargetSizeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetTargetSizeAttribute();
		
		/// <summary>Member SetTargetSizeAttribute </summary>
		/// <param name='aTargetSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTargetSizeAttribute(System.UInt32  aTargetSize);
		
		/// <summary>Member GetNumDropItemsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetNumDropItemsAttribute();
		
		/// <summary>Member GetSourceDocumentAttribute </summary>
		/// <returns>A nsIDOMDocument </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument  GetSourceDocumentAttribute();
		
		/// <summary>Member GetSourceNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetSourceNodeAttribute();
		
		/// <summary>Member GetDataTransferAttribute </summary>
		/// <returns>A nsIDOMDataTransfer </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDataTransfer  GetDataTransferAttribute();
		
		/// <summary>Member SetDataTransferAttribute </summary>
		/// <param name='aDataTransfer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataTransferAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer  aDataTransfer);
		
		/// <summary>Member GetData </summary>
		/// <param name='aTransferable'> </param>
		/// <param name='aItemIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetData([MarshalAs(UnmanagedType.Interface)] nsITransferable  aTransferable, System.UInt32  aItemIndex);
		
		/// <summary>Member IsDataFlavorSupported </summary>
		/// <param name='aDataFlavor'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDataFlavorSupported([MarshalAs(UnmanagedType.LPStr)] System.String  aDataFlavor);
	}
}