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
// Generated by IDLImporter from file nsIToolkitProfileService.idl
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
	[Guid("b81c33a6-1ce8-4695-856b-02b7f15cc114")]
	public interface nsIToolkitProfileService
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStartWithLastProfileAttribute();
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartWithLastProfileAttribute([MarshalAs(UnmanagedType.U1)] bool aStartWithLastProfile);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStartOfflineAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aStartOffline);
		
		/// <summary>
        ///nsIToolkitProfile </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetProfilesAttribute();
		
		/// <summary>
        /// The currently selected profile (the one used or about to be used by the
        /// browser).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile GetSelectedProfileAttribute();
		
		/// <summary>
        /// The currently selected profile (the one used or about to be used by the
        /// browser).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectedProfileAttribute([MarshalAs(UnmanagedType.Interface)] nsIToolkitProfile aSelectedProfile);
		
		/// <summary>
        /// The default profile (the one used or about to be used by the
        /// browser if no other profile is specified at runtime). This is the profile
        /// marked with Default=1 in profiles.ini and is usually the same as
        /// selectedProfile, except on Developer Edition.
        ///
        /// Developer Edition uses a profile named "dev-edition-default" as the
        /// default profile (which it creates if it doesn't exist), unless a special
        /// empty file named "ignore-dev-edition-profile" is present next to
        /// profiles.ini. In that case Developer Edition behaves the same as any
        /// other build of Firefox.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile GetDefaultProfileAttribute();
		
		/// <summary>
        /// The default profile (the one used or about to be used by the
        /// browser if no other profile is specified at runtime). This is the profile
        /// marked with Default=1 in profiles.ini and is usually the same as
        /// selectedProfile, except on Developer Edition.
        ///
        /// Developer Edition uses a profile named "dev-edition-default" as the
        /// default profile (which it creates if it doesn't exist), unless a special
        /// empty file named "ignore-dev-edition-profile" is present next to
        /// profiles.ini. In that case Developer Edition behaves the same as any
        /// other build of Firefox.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultProfileAttribute([MarshalAs(UnmanagedType.Interface)] nsIToolkitProfile aDefaultProfile);
		
		/// <summary>
        /// Get a profile by name. This is mainly for use by the -P
        /// commandline flag.
        ///
        /// @param aName The profile name to find.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile GetProfileByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Lock an arbitrary path as a profile. If the path does not exist, it
        /// will be created and the defaults copied from the application directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProfileLock LockProfilePath([MarshalAs(UnmanagedType.Interface)] nsIFile aDirectory, [MarshalAs(UnmanagedType.Interface)] nsIFile aTempDirectory);
		
		/// <summary>
        /// Create a new profile.
        ///
        /// The profile temporary directory will be chosen based on where the
        /// profile directory is located.
        ///
        /// @param aRootDir
        /// The profile directory. May be null, in which case a suitable
        /// default will be chosen based on the profile name.
        /// @param aName
        /// The profile name.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile CreateProfile([MarshalAs(UnmanagedType.Interface)] nsIFile aRootDir, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Create the default profile for an application.
        ///
        /// The profile will be typically in
        /// {Application Data}/.profilename/{salt}.default or
        /// {Application Data}/.appname/{salt}.default
        /// or if aVendorName is provided
        /// {Application Data}/.vendor/appname/{salt}.default
        ///
        /// @note Either aProfileName or aAppName must be non-empty
        ///
        /// The contents of aProfileDefaultsDir will be copied to the
        /// new profile directory.
        ///
        /// @param  aProfileName
        /// The name of the profile
        /// @param  aAppName
        /// The name of the application
        /// @param  aVendorName
        /// The name of the vendor
        /// @param  aProfileDefaultsDir
        /// The location where the profile defaults are.
        /// @return The created profile.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile CreateDefaultProfileForApp([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aProfileName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAppName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aVendorName, [MarshalAs(UnmanagedType.Interface)] nsIFile aProfileDefaultsDir);
		
		/// <summary>
        /// Returns the number of profiles.
        /// @return 0, 1, or 2. More than 2 profiles will always return 2.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProfileCountAttribute();
		
		/// <summary>
        /// Flush the profiles list file.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Flush();
	}
}
