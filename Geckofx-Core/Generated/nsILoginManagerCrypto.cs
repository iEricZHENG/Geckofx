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
// Generated by IDLImporter from file nsILoginManagerCrypto.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2030770e-542e-40cd-8061-cd9d4ad4227f")]
	public interface nsILoginManagerCrypto
	{
		
		/// <summary>
        /// encrypt
        ///
        /// @param plainText
        /// The string to be encrypted.
        ///
        /// Encrypts the specified string, returning the ciphertext value.
        ///
        /// NOTE: The current implemention of this inferface simply uses NSS/PSM's
        /// "Secret Decoder Ring" service. It is not recommended for general
        /// purpose encryption/decryption.
        ///
        /// Can throw if the user cancels entry of their master password.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Encrypt([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase plainText, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// decrypt
        ///
        /// @param cipherText
        /// The string to be decrypted.
        ///
        /// Decrypts the specified string, returning the plaintext value.
        ///
        /// Can throw if the user cancels entry of their master password, or if the
        /// cipherText value can not be successfully decrypted (eg, if it was
        /// encrypted with some other key).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Decrypt([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase cipherText, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// uiBusy
        ///
        /// True when a master password prompt is being displayed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUiBusyAttribute();
		
		/// <summary>
        /// isLoggedIn
        ///
        /// Current login state of the token used for encryption. If the user is
        /// not logged in, performing a crypto operation will result in a master
        /// password prompt.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsLoggedInAttribute();
		
		/// <summary>
        /// defaultEncType
        ///
        /// Default encryption type used by an implementation of this interface.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDefaultEncTypeAttribute();
	}
	
	/// <summary>nsILoginManagerCryptoConsts </summary>
	public class nsILoginManagerCryptoConsts
	{
		
		// <summary>
        //This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const ulong ENCTYPE_BASE64 = 0;
		
		// 
		public const ulong ENCTYPE_SDR = 1;
	}
}
