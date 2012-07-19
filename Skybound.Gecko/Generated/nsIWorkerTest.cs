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
// Generated by IDLImporter from file nsIWorkerTest.idl
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

	
	
	/// <summary>nsIWorkerTestCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("10f8ebdf-1373-4640-9c34-53dee99f526f")]
	public interface nsIWorkerTestCallback
	{
		
		/// <summary>Member Onmessage </summary>
		/// <param name='data'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Onmessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		/// <summary>Member Onerror </summary>
		/// <param name='data'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Onerror([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
	}
	
	/// <summary>nsIWorkerTest </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("887a0614-a0f0-4c0e-80e0-cf31e6d4e286")]
	public interface nsIWorkerTest
	{
		
		/// <summary>Member PostMessage </summary>
		/// <param name='data'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		/// <summary>Member Terminate </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Terminate();
		
		/// <summary>Member GetCallbackAttribute </summary>
		/// <returns>A nsIWorkerTestCallback</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWorkerTestCallback GetCallbackAttribute();
		
		/// <summary>Member SetCallbackAttribute </summary>
		/// <param name='aCallback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCallbackAttribute([MarshalAs(UnmanagedType.Interface)] nsIWorkerTestCallback aCallback);
	}
}
