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
// Generated by IDLImporter from file nsIAudioManager.idl
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

	
	
	/// <summary>nsIAudioManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d2124467-7209-4b2e-a91a-cf3f90681e3c")]
	public interface nsIAudioManager
	{
		
		/// <summary>
        /// Microphone muted?
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMicrophoneMutedAttribute();
		
		/// <summary>
        /// Microphone muted?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMicrophoneMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aMicrophoneMuted);
		
		/// <summary>
        /// The master volume.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetMasterVolumeAttribute();
		
		/// <summary>
        /// The master volume.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMasterVolumeAttribute(float aMasterVolume);
		
		/// <summary>
        /// Master volume muted?
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMasterMutedAttribute();
		
		/// <summary>
        /// Master volume muted?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMasterMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aMasterMuted);
		
		/// <summary>Member GetPhoneStateAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPhoneStateAttribute();
		
		/// <summary>Member SetPhoneStateAttribute </summary>
		/// <param name='aPhoneState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPhoneStateAttribute(int aPhoneState);
		
		/// <summary>Member SetForceForUse </summary>
		/// <param name='usage'> </param>
		/// <param name='force'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetForceForUse(int usage, int force);
		
		/// <summary>Member GetForceForUse </summary>
		/// <param name='usage'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetForceForUse(int usage);
	}
	
	/// <summary>nsIAudioManagerConsts </summary>
	public class nsIAudioManagerConsts
	{
		
		// <summary>
        // Set the phone's audio mode.
        // </summary>
		public const long PHONE_STATE_INVALID = -2;
		
		// 
		public const long PHONE_STATE_CURRENT = -1;
		
		// 
		public const long PHONE_STATE_NORMAL = 0;
		
		// 
		public const long PHONE_STATE_RINGTONE = 1;
		
		// 
		public const long PHONE_STATE_IN_CALL = 2;
		
		// 
		public const long PHONE_STATE_IN_COMMUNICATION = 3;
		
		// <summary>
        // Configure a particular device ("force") to be used for one of the uses
        // (communication, media playback, etc.)
        // </summary>
		public const long FORCE_NONE = 0;
		
		// <summary>
        // the default
        // </summary>
		public const long FORCE_SPEAKER = 1;
		
		// 
		public const long FORCE_HEADPHONES = 2;
		
		// 
		public const long FORCE_BT_SCO = 3;
		
		// 
		public const long FORCE_BT_A2DP = 4;
		
		// 
		public const long FORCE_WIRED_ACCESSORY = 5;
		
		// 
		public const long FORCE_BT_CAR_DOCK = 6;
		
		// 
		public const long FORCE_BT_DESK_DOCK = 7;
		
		// 
		public const long USE_COMMUNICATION = 0;
		
		// 
		public const long USE_MEDIA = 1;
		
		// 
		public const long USE_RECORD = 2;
		
		// 
		public const long USE_DOCK = 3;
	}
}
