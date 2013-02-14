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
// Generated by IDLImporter from file nsIDOMVoicemailStatus.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8c58859a-e006-466a-ad76-b188ba0918ab")]
	public interface nsIDOMMozVoicemailStatus
	{
		
		/// <summary>
        /// Whether or not there are messages waiting in the voicemail box
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasMessagesAttribute();
		
		/// <summary>
        /// The total message count. Some voicemail indicators will only specify that
        /// messages are waiting, but not the actual number. In that case, the value
        /// of messageCount will be MESSAGE_COUNT_UNKNOWN (-1).
        ///
        /// Logic for a voicemail notification might look something like:
        /// if (status.hasMessages) {
        /// // show new voicemail notification
        /// if (status.messageCount > 0) {
        /// // add a label for the message count
        /// }
        /// } else {
        /// // hide the voicemail notification
        /// }
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMessageCountAttribute();
		
		/// <summary>
        /// Return call number received for this voicemail status, or null if one
        /// wasn't provided.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReturnNumberAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReturnNumber);
		
		/// <summary>
        /// Displayable return call message received for this voicemail status, or null
        /// if one wasn't provided.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReturnMessageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReturnMessage);
	}
	
	/// <summary>nsIDOMMozVoicemailStatusConsts </summary>
	public class nsIDOMMozVoicemailStatusConsts
	{
		
		// <summary>
        // There are voicemail messages waiting, but the count is unknown.
        // </summary>
		public const long MESSAGE_COUNT_UNKNOWN = -1;
	}
}
