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
// Generated by IDLImporter from file nsIComponentRegistrar.idl
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
    /// The nsIComponentRegistrar interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2417cbfe-65ad-48a6-b4b6-eb84db174392")]
	public interface nsIComponentRegistrar
	{
		
		/// <summary>
        /// autoRegister
        ///
        /// Register a .manifest file, or an entire directory containing
        /// these files. Registration lasts for this run only, and is not cached.
        ///
        /// @note Formerly this method would register component files directly. This
        /// is no longer supported.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoRegister([MarshalAs(UnmanagedType.Interface)] nsIFile aSpec);
		
		/// <summary>
        /// autoUnregister
        /// @status OBSOLETE: This method is no longer implemented, but preserved
        /// in this interface for binary compatibility with
        /// Mozilla 1.9.2.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoUnregister([MarshalAs(UnmanagedType.Interface)] nsIFile aSpec);
		
		/// <summary>
        /// registerFactory
        ///
        /// Register a factory with a given ContractID, CID and Class Name.
        ///
        /// @param aClass      : CID of object
        /// @param aClassName  : Class Name of CID (unused)
        /// @param aContractID : ContractID associated with CID aClass. May be null
        /// if no contract ID is needed.
        /// @param aFactory    : Factory that will be registered for CID aClass.
        /// If aFactory is null, the contract will be associated
        /// with a previously registered CID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFactory(ref System.Guid aClass, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aContractID, [MarshalAs(UnmanagedType.Interface)] nsIFactory aFactory);
		
		/// <summary>
        /// unregisterFactory
        ///
        /// Unregister a factory associated with CID aClass.
        ///
        /// @param aClass   : CID being unregistered
        /// @param aFactory : Factory previously registered to create instances of
        /// CID aClass.
        ///
        /// @return NS_OK     Unregistration was successful.
        /// NS_ERROR* Method failure.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFactory(ref System.Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsIFactory aFactory);
		
		/// <summary>
        /// registerFactoryLocation
        /// @status OBSOLETE: This method is no longer implemented, but preserved
        /// in this interface for binary compatibility with
        /// Mozilla 1.9.2.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFactoryLocation(ref System.Guid aClass, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aContractID, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile, [MarshalAs(UnmanagedType.LPStr)] string aLoaderStr, [MarshalAs(UnmanagedType.LPStr)] string aType);
		
		/// <summary>
        /// unregisterFactoryLocation
        /// @status OBSOLETE: This method is no longer implemented, but preserved
        /// in this interface for binary compatibility with
        /// Mozilla 1.9.2.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFactoryLocation(ref System.Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
		
		/// <summary>
        /// isCIDRegistered
        ///
        /// Returns true if a factory is registered for the CID.
        ///
        /// @param aClass : CID queried for registeration
        /// @return       : true if a factory is registered for CID
        /// false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCIDRegistered(ref System.Guid aClass);
		
		/// <summary>
        /// isContractIDRegistered
        ///
        /// Returns true if a factory is registered for the contract id.
        ///
        /// @param aClass : contract id queried for registeration
        /// @return       : true if a factory is registered for contract id
        /// false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsContractIDRegistered([MarshalAs(UnmanagedType.LPStr)] string aContractID);
		
		/// <summary>
        /// enumerateCIDs
        ///
        /// Enumerate the list of all registered CIDs.
        ///
        /// @return : enumerator for CIDs.  Elements of the enumeration can be QI'ed
        /// for the nsISupportsID interface.  From the nsISupportsID, you
        /// can obtain the actual CID.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateCIDs();
		
		/// <summary>
        /// enumerateContractIDs
        ///
        /// Enumerate the list of all registered ContractIDs.
        ///
        /// @return : enumerator for ContractIDs. Elements of the enumeration can be
        /// QI'ed for the nsISupportsCString interface.  From  the
        /// nsISupportsCString interface, you can obtain the actual
        /// Contract ID string.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateContractIDs();
		
		/// <summary>
        /// CIDToContractID
        /// @status OBSOLETE: This method is no longer implemented, but preserved
        /// in this interface for binary compatibility with
        /// Mozilla 1.9.2.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string CIDToContractID(ref System.Guid aClass);
		
		/// <summary>
        /// contractIDToCID
        ///
        /// Returns the CID for a given Contract ID, if one exists and is registered.
        ///
        /// @return : Contract ID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr ContractIDToCID([MarshalAs(UnmanagedType.LPStr)] string aContractID);
	}
}
