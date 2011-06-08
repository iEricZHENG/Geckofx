// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: amIWebInstaller.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file amIWebInstaller.idl
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
	
	
	/// <summary>amIWebInstaller </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4fdf4f84-73dc-4857-9bbe-84895e8afd5d")]
	public interface amIWebInstaller
	{
		
		/// <summary>Member IsInstallEnabled </summary>
		/// <param name='aMimetype'> </param>
		/// <param name='aReferer'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsInstallEnabled([MarshalAs(UnmanagedType.LPStruct)] nsAString aMimetype, [MarshalAs(UnmanagedType.Interface)] nsIURI  aReferer);
		
		/// <summary>Member InstallAddonsFromWebpage </summary>
		/// <param name='aMimetype'> </param>
		/// <param name='aWindow'> </param>
		/// <param name='aReferer'> </param>
		/// <param name='aUris'> </param>
		/// <param name='aHashes'> </param>
		/// <param name='aNames'> </param>
		/// <param name='aIcons'> </param>
		/// <param name='aCallback'> </param>
		/// <param name='aInstallCount'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool InstallAddonsFromWebpage([MarshalAs(UnmanagedType.LPStruct)] nsAString aMimetype, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindowInternal  aWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI  aReferer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=8)] string aUris, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=8)] string aHashes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=8)] string aNames, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=8)] string aIcons, amIInstallCallback  aCallback, System.UInt32  aInstallCount);
	}
}