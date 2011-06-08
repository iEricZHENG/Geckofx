// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsILoginManagerStorage.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsILoginManagerStorage.idl
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
	
	
	/// <summary>nsILoginManagerStorage </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("32a4f9f1-60a8-4971-b54e-71ad661483ae")]
	public interface nsILoginManagerStorage
	{
		
		/// <summary>Member Init </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		/// <summary>Member InitWithFile </summary>
		/// <param name='aInputFile'> </param>
		/// <param name='aOutputFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithFile([MarshalAs(UnmanagedType.Interface)] nsIFile  aInputFile, [MarshalAs(UnmanagedType.Interface)] nsIFile  aOutputFile);
		
		/// <summary>Member AddLogin </summary>
		/// <param name='aLogin'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddLogin([MarshalAs(UnmanagedType.Interface)] nsILoginInfo  aLogin);
		
		/// <summary>Member RemoveLogin </summary>
		/// <param name='aLogin'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveLogin([MarshalAs(UnmanagedType.Interface)] nsILoginInfo  aLogin);
		
		/// <summary>Member ModifyLogin </summary>
		/// <param name='oldLogin'> </param>
		/// <param name='newLoginData'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ModifyLogin([MarshalAs(UnmanagedType.Interface)] nsILoginInfo  oldLogin, [MarshalAs(UnmanagedType.Interface)] nsISupports  newLoginData);
		
		/// <summary>Member RemoveAllLogins </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllLogins();
		
		/// <summary>Member GetAllLogins </summary>
		/// <param name='count'> </param>
		/// <returns>A nsILoginInfo </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoginInfo  GetAllLogins(out System.UInt32  count);
		
		/// <summary>Member GetAllEncryptedLogins </summary>
		/// <param name='count'> </param>
		/// <returns>A nsILoginInfo </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoginInfo  GetAllEncryptedLogins(out System.UInt32  count);
		
		/// <summary>Member SearchLogins </summary>
		/// <param name='count'> </param>
		/// <param name='matchData'> </param>
		/// <returns>A nsILoginInfo </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoginInfo  SearchLogins(out System.UInt32  count, [MarshalAs(UnmanagedType.Interface)] nsIPropertyBag  matchData);
		
		/// <summary>Member GetAllDisabledHosts </summary>
		/// <param name='count'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetAllDisabledHosts(out System.UInt32  count);
		
		/// <summary>Member GetLoginSavingEnabled </summary>
		/// <param name='aHost'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLoginSavingEnabled([MarshalAs(UnmanagedType.LPStruct)] nsAString aHost);
		
		/// <summary>Member SetLoginSavingEnabled </summary>
		/// <param name='aHost'> </param>
		/// <param name='isEnabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoginSavingEnabled([MarshalAs(UnmanagedType.LPStruct)] nsAString aHost, System.Boolean  isEnabled);
		
		/// <summary>Member FindLogins </summary>
		/// <param name='count'> </param>
		/// <param name='aHostname'> </param>
		/// <param name='aActionURL'> </param>
		/// <param name='aHttpRealm'> </param>
		/// <returns>A nsILoginInfo </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoginInfo  FindLogins(out System.UInt32  count, [MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname, [MarshalAs(UnmanagedType.LPStruct)] nsAString aActionURL, [MarshalAs(UnmanagedType.LPStruct)] nsAString aHttpRealm);
		
		/// <summary>Member CountLogins </summary>
		/// <param name='aHostname'> </param>
		/// <param name='aActionURL'> </param>
		/// <param name='aHttpRealm'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint CountLogins([MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname, [MarshalAs(UnmanagedType.LPStruct)] nsAString aActionURL, [MarshalAs(UnmanagedType.LPStruct)] nsAString aHttpRealm);
		
		/// <summary>Member GetUiBusyAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetUiBusyAttribute();
	}
}