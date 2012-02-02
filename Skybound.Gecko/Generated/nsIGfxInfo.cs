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
// Generated by IDLImporter from file nsIGfxInfo.idl
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
	
	
	/// <summary>
    ///NOTE: this interface is completely undesigned, not stable and likely to change </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a67c77af-2952-4028-93ab-e7bc3b43cf81")]
	public interface nsIGfxInfo
	{
		
		/// <summary>
        /// These are win32-specific
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetD2DEnabledAttribute();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDWriteEnabledAttribute();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAzureEnabledAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDWriteVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDWriteVersion);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCleartypeParametersAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCleartypeParameters);
		
		/// <summary>
        /// The name of the display adapter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDescription);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDescription2Attribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDescription2);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriver);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriver2Attribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriver2);
		
		/// <summary>
        ///These types are inspired by DXGI_ADAPTER_DESC </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAdapterVendorIDAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAdapterVendorID2Attribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAdapterDeviceIDAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAdapterDeviceID2Attribute();
		
		/// <summary>
        /// The amount of RAM in MB in the display adapter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterRAMAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterRAM);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterRAM2Attribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterRAM2);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriverVersion);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverVersion2Attribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriverVersion2);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverDateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriverDate);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverDate2Attribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriverDate2);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsGPU2ActiveAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFailures(ref uint failureCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] failures);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogFailure([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase failure);
		
		/// <summary>
        /// Ask about a feature, and return the status of that feature
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFeatureStatus(int aFeature);
		
		/// <summary>
        /// Ask about a feature, return the minimum driver version required for it if its status is
        /// FEATURE_BLOCKED_DRIVER_VERSION, otherwise return an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFeatureSuggestedDriverVersion(int aFeature, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// WebGL info; valid params are "full-renderer", "vendor", "renderer", "version",
        /// "shading_language_version", "extensions".  These return info from
        /// underlying GL impl that's used to implement WebGL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWebGLParameter([MarshalAs(UnmanagedType.LPStruct)] nsAString aParam, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// only useful on X11
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetData();
	}
}
