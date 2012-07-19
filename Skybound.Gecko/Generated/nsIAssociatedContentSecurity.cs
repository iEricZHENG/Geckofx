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
// Generated by IDLImporter from file nsIAssociatedContentSecurity.idl
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
    /// This interface is used to cache associated (sub) content security
    /// state. That is determined asynchronously based on callback notification
    /// while loading the content and its sub content particles.
    ///
    /// Some optimizations like bfcaching removes these callback notifications
    /// and therefor the subcontent state could not be determined. In such
    /// a case it is loaded from this object stored in nsIChannel.securityInfo.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6AC9A699-D12A-45dc-9B02-9E5E0DD831B9")]
	public interface nsIAssociatedContentSecurity
	{
		
		/// <summary>
        /// This interface is used to cache associated (sub) content security
        /// state. That is determined asynchronously based on callback notification
        /// while loading the content and its sub content particles.
        ///
        /// Some optimizations like bfcaching removes these callback notifications
        /// and therefor the subcontent state could not be determined. In such
        /// a case it is loaded from this object stored in nsIChannel.securityInfo.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCountSubRequestsHighSecurityAttribute();
		
		/// <summary>
        /// This interface is used to cache associated (sub) content security
        /// state. That is determined asynchronously based on callback notification
        /// while loading the content and its sub content particles.
        ///
        /// Some optimizations like bfcaching removes these callback notifications
        /// and therefor the subcontent state could not be determined. In such
        /// a case it is loaded from this object stored in nsIChannel.securityInfo.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCountSubRequestsHighSecurityAttribute(int aCountSubRequestsHighSecurity);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCountSubRequestsLowSecurityAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCountSubRequestsLowSecurityAttribute(int aCountSubRequestsLowSecurity);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCountSubRequestsBrokenSecurityAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCountSubRequestsBrokenSecurityAttribute(int aCountSubRequestsBrokenSecurity);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCountSubRequestsNoSecurityAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCountSubRequestsNoSecurityAttribute(int aCountSubRequestsNoSecurity);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Flush();
	}
}
