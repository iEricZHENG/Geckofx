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
// Generated by IDLImporter from file nsIXPCScriptable.idl
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

	
	
	/// <summary>
    /// Note: This is not really an XPCOM interface.  For example, callers must
    /// guarantee that they set the *_retval of the various methods that return a
    /// boolean to PR_TRUE before making the call.  Implementations may skip writing
    /// to *_retval unless they want to return PR_FALSE.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fca22e1e-a2bf-456e-83db-f73e8de0f7c5")]
	public interface nsIXPCScriptable
	{
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetClassNameAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetScriptableFlagsAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreCreate([MarshalAs(UnmanagedType.Interface)] nsISupports nativeObj, System.IntPtr cx, System.IntPtr globalObj, ref System.IntPtr parentObj);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostCreate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AddProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DelProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, System.IntPtr vp);
		
		/// <summary>
        /// this method does something.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, System.IntPtr vp);
		
		/// <summary>
        /// this method does something.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SetProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Enumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NewEnumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, uint enum_op, System.IntPtr statep, ref System.IntPtr idp);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NewResolve([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, uint flags, ref System.IntPtr objp);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Convert([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, uint type, System.IntPtr vp);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finalize([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr fop, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CheckAccess([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, uint mode, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Call([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, uint argc, System.IntPtr argv, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Construct([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, uint argc, System.IntPtr argv, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasInstance([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, Gecko.JsVal val, [MarshalAs(UnmanagedType.U1)] ref bool bp);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equality([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, Gecko.JsVal val);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr OuterObject([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostCreatePrototype(System.IntPtr cx, System.IntPtr proto);
	}
	
	/// <summary>nsIXPCScriptableConsts </summary>
	public class nsIXPCScriptableConsts
	{
		
		// <summary>
        //bitflags used for 'flags' (only 32 bits available!) </summary>
		public const long WANT_PRECREATE = 1<<0;
		
		// 
		public const long WANT_CREATE = 1<<1;
		
		// 
		public const long WANT_POSTCREATE = 1<<2;
		
		// 
		public const long WANT_ADDPROPERTY = 1<<3;
		
		// 
		public const long WANT_DELPROPERTY = 1<<4;
		
		// 
		public const long WANT_GETPROPERTY = 1<<5;
		
		// 
		public const long WANT_SETPROPERTY = 1<<6;
		
		// 
		public const long WANT_ENUMERATE = 1<<7;
		
		// 
		public const long WANT_NEWENUMERATE = 1<<8;
		
		// 
		public const long WANT_NEWRESOLVE = 1<<9;
		
		// 
		public const long WANT_CONVERT = 1<<10;
		
		// 
		public const long WANT_FINALIZE = 1<<11;
		
		// 
		public const long WANT_CHECKACCESS = 1<<12;
		
		// 
		public const long WANT_CALL = 1<<13;
		
		// 
		public const long WANT_CONSTRUCT = 1<<14;
		
		// 
		public const long WANT_HASINSTANCE = 1<<15;
		
		// <summary>
        // Unused bit here!
        // </summary>
		public const long USE_JSSTUB_FOR_ADDPROPERTY = 1<<17;
		
		// 
		public const long USE_JSSTUB_FOR_DELPROPERTY = 1<<18;
		
		// 
		public const long USE_JSSTUB_FOR_SETPROPERTY = 1<<19;
		
		// 
		public const long DONT_ENUM_STATIC_PROPS = 1<<20;
		
		// 
		public const long DONT_ENUM_QUERY_INTERFACE = 1<<21;
		
		// 
		public const long DONT_ASK_INSTANCE_FOR_SCRIPTABLE = 1<<22;
		
		// 
		public const long CLASSINFO_INTERFACES_ONLY = 1<<23;
		
		// 
		public const long ALLOW_PROP_MODS_DURING_RESOLVE = 1<<24;
		
		// 
		public const long ALLOW_PROP_MODS_TO_PROTOTYPE = 1<<25;
		
		// 
		public const long IS_GLOBAL_OBJECT = 1<<26;
		
		// 
		public const long DONT_REFLECT_INTERFACE_NAMES = 1<<27;
		
		// 
		public const long WANT_EQUALITY = 1<<28;
		
		// 
		public const long WANT_OUTER_OBJECT = 1<<29;
		
		// 
		public const long USE_STUB_EQUALITY_HOOK = 1<<30;
		
		// <summary>
        // with this bit set.
        // </summary>
		public const long RESERVED = 1<<31;
	}
}
