// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWifiMonitor.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWifiMonitor.idl
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
	
	
	/// <summary>nsIWifiMonitor </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F289701E-D9AF-4685-BC2F-E4226FF7C018")]
	public interface nsIWifiMonitor
	{
		
		/// <summary>Member StartWatching </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartWatching([MarshalAs(UnmanagedType.Interface)] nsIWifiListener  aListener);
		
		/// <summary>Member StopWatching </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopWatching([MarshalAs(UnmanagedType.Interface)] nsIWifiListener  aListener);
	}
}