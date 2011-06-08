// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDownloadHistory.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDownloadHistory.idl
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
	
	
	/// <summary>nsIDownloadHistory </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("202533cd-a8f1-4ee4-8d20-3a6a0d2c6c51")]
	public interface nsIDownloadHistory
	{
		
		/// <summary>Member AddDownload </summary>
		/// <param name='aSource'> </param>
		/// <param name='aReferrer'> </param>
		/// <param name='aStartTime'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDownload([MarshalAs(UnmanagedType.Interface)] nsIURI  aSource, [MarshalAs(UnmanagedType.Interface)] nsIURI  aReferrer, System.UInt32  aStartTime);
	}
}