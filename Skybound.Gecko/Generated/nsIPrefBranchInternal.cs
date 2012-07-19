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
// Generated by IDLImporter from file nsIPrefBranchInternal.idl
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
    /// An empty interface to provide backwards compatibility for existing code that
    /// bsmedberg didn't want to break all at once. Don't use me!
    ///
    /// @status NON-FROZEN interface WHICH WILL PROBABLY GO AWAY.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("355bd1e9-248a-438b-809d-e0db1b287882")]
	public interface nsIPrefBranchInternal : nsIPrefBranch2
	{
		
		/// <summary>
        /// Called to get the root on which this branch is based, such as
        /// "browser.startup."
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetRootAttribute();
		
		/// <summary>
        /// Called to determine the type of a specific preference.
        ///
        /// @param aPrefName The preference to get the type of.
        ///
        /// @return long     A value representing the type of the preference. This
        /// value will be PREF_STRING, PREF_INT, or PREF_BOOL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetPrefType([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to get the state of an individual boolean preference.
        ///
        /// @param aPrefName The boolean preference to get the state of.
        ///
        /// @return boolean  The value of the requested boolean preference.
        ///
        /// @see setBoolPref
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to set the state of an individual boolean preference.
        ///
        /// @param aPrefName The boolean preference to set the state of.
        /// @param aValue    The boolean value to set the preference to.
        ///
        /// @return NS_OK The value was successfully set.
        /// @return Other The value was not set or is the wrong type.
        ///
        /// @see getBoolPref
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, [MarshalAs(UnmanagedType.U1)] bool aValue);
		
		/// <summary>
        /// Called to get the state of an individual string preference.
        ///
        /// @param aPrefName The string preference to retrieve.
        ///
        /// @return string   The value of the requested string preference.
        ///
        /// @see setCharPref
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to set the state of an individual string preference.
        ///
        /// @param aPrefName The string preference to set.
        /// @param aValue    The string value to set the preference to.
        ///
        /// @return NS_OK The value was successfully set.
        /// @return Other The value was not set or is the wrong type.
        ///
        /// @see getCharPref
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, [MarshalAs(UnmanagedType.LPStr)] string aValue);
		
		/// <summary>
        /// Called to get the state of an individual integer preference.
        ///
        /// @param aPrefName The integer preference to get the value of.
        ///
        /// @return long     The value of the requested integer preference.
        ///
        /// @see setIntPref
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to set the state of an individual integer preference.
        ///
        /// @param aPrefName The integer preference to set the value of.
        /// @param aValue    The integer value to set the preference to.
        ///
        /// @return NS_OK The value was successfully set.
        /// @return Other The value was not set or is the wrong type.
        ///
        /// @see getIntPref
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, int aValue);
		
		/// <summary>
        /// Called to get the state of an individual complex preference. A complex
        /// preference is a preference which represents an XPCOM object that can not
        /// be easily represented using a standard boolean, integer or string value.
        ///
        /// @param aPrefName The complex preference to get the value of.
        /// @param aType     The XPCOM interface that this complex preference
        /// represents. Interfaces currently supported are:
        /// - nsILocalFile
        /// - nsISupportsString (UniChar)
        /// - nsIPrefLocalizedString (Localized UniChar)
        /// @param aValue    The XPCOM object into which to the complex preference
        /// value should be retrieved.
        ///
        /// @return NS_OK The value was successfully retrieved.
        /// @return Other The value does not exist or is the wrong type.
        ///
        /// @see setComplexValue
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref System.Guid aType);
		
		/// <summary>
        /// Called to set the state of an individual complex preference. A complex
        /// preference is a preference which represents an XPCOM object that can not
        /// be easily represented using a standard boolean, integer or string value.
        ///
        /// @param aPrefName The complex preference to set the value of.
        /// @param aType     The XPCOM interface that this complex preference
        /// represents. Interfaces currently supported are:
        /// - nsILocalFile
        /// - nsISupportsString (UniChar)
        /// - nsIPrefLocalizedString (Localized UniChar)
        /// @param aValue    The XPCOM object from which to set the complex preference
        /// value.
        ///
        /// @return NS_OK The value was successfully set.
        /// @return Other The value was not set or is the wrong type.
        ///
        /// @see getComplexValue
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref System.Guid aType, [MarshalAs(UnmanagedType.Interface)] nsISupports aValue);
		
		/// <summary>
        /// Called to clear a user set value from a specific preference. This will, in
        /// effect, reset the value to the default value. If no default value exists
        /// the preference will cease to exist.
        ///
        /// @param aPrefName The preference to be cleared.
        ///
        /// @note
        /// This method does nothing if this object is a default branch.
        ///
        /// @return NS_OK The user preference was successfully cleared.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ClearUserPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to lock a specific preference. Locking a preference will cause the
        /// preference service to always return the default value regardless of
        /// whether there is a user set value or not.
        ///
        /// @param aPrefName The preference to be locked.
        ///
        /// @note
        /// This method can be called on either a default or user branch but, in
        /// effect, always operates on the default branch.
        ///
        /// @return NS_OK The preference was successfully locked.
        /// @return Other The preference does not exist or an error occurred.
        ///
        /// @see unlockPref
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to check if a specific preference has a user value associated to
        /// it.
        ///
        /// @param aPrefName The preference to be tested.
        ///
        /// @note
        /// This method can be called on either a default or user branch but, in
        /// effect, always operates on the user branch.
        ///
        /// @note
        /// If a preference was manually set to a value that equals the default value,
        /// then the preference no longer has a user set value, i.e. it is
        /// considered reset to its default value.
        /// In particular, this method will return false for such a preference and
        /// the preference will not be saved to a file by nsIPrefService.savePrefFile.
        ///
        /// @return boolean  true  The preference has a user set value.
        /// false The preference only has a default value.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PrefHasUserValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to check if a specific preference is locked. If a preference is
        /// locked calling its Get method will always return the default value.
        ///
        /// @param aPrefName The preference to be tested.
        ///
        /// @note
        /// This method can be called on either a default or user branch but, in
        /// effect, always operates on the default branch.
        ///
        /// @return boolean  true  The preference is locked.
        /// false The preference is not locked.
        ///
        /// @see lockPref
        /// @see unlockPref
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PrefIsLocked([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to unlock a specific preference. Unlocking a previously locked
        /// preference allows the preference service to once again return the user set
        /// value of the preference.
        ///
        /// @param aPrefName The preference to be unlocked.
        ///
        /// @note
        /// This method can be called on either a default or user branch but, in
        /// effect, always operates on the default branch.
        ///
        /// @return NS_OK The preference was successfully unlocked.
        /// @return Other The preference does not exist or an error occurred.
        ///
        /// @see lockPref
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void UnlockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		/// <summary>
        /// Called to remove all of the preferences referenced by this branch.
        ///
        /// @param aStartingAt The point on the branch at which to start the deleting
        /// preferences. Pass in "" to remove all preferences
        /// referenced by this branch.
        ///
        /// @note
        /// This method can be called on either a default or user branch but, in
        /// effect, always operates on both.
        ///
        /// @return NS_OK The preference(s) were successfully removed.
        /// @return Other The preference(s) do not exist or an error occurred.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void DeleteBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);
		
		/// <summary>
        /// Returns an array of strings representing the child preferences of the
        /// root of this branch.
        ///
        /// @param aStartingAt The point on the branch at which to start enumerating
        /// the child preferences. Pass in "" to enumerate all
        /// preferences referenced by this branch.
        /// @param aCount      Receives the number of elements in the array.
        /// @param aChildArray Receives the array of child preferences.
        ///
        /// @note
        /// This method can be called on either a default or user branch but, in
        /// effect, always operates on both.
        ///
        /// @return NS_OK The preference list was successfully retrieved.
        /// @return Other The preference(s) do not exist or an error occurred.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetChildList([MarshalAs(UnmanagedType.LPStr)] string aStartingAt, ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref string[] aChildArray);
		
		/// <summary>
        /// Called to reset all of the preferences referenced by this branch to their
        /// default values.
        ///
        /// @param aStartingAt The point on the branch at which to start the resetting
        /// preferences to their default values. Pass in "" to
        /// reset all preferences referenced by this branch.
        ///
        /// @note
        /// This method can be called on either a default or user branch but, in
        /// effect, always operates on the user branch.
        ///
        /// @return NS_OK The preference(s) were successfully reset.
        /// @return Other The preference(s) do not exist or an error occurred.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ResetBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);
		
		/// <summary>
        /// Add a preference change observer. On preference changes, the following
        /// arguments will be passed to the nsIObserver.observe() method:
        /// aSubject - The nsIPrefBranch object (this)
        /// aTopic   - The string defined by NS_PREFBRANCH_PREFCHANGE_TOPIC_ID
        /// aData    - The name of the preference which has changed, relative to
        /// the |root| of the aSubject branch.
        ///
        /// aSubject.get*Pref(aData) will get the new value of the modified
        /// preference. For example, if your observer is registered with
        /// addObserver("bar.", ...) on a branch with root "foo.", modifying
        /// the preference "foo.bar.baz" will trigger the observer, and aData
        /// parameter will be "bar.baz".
        ///
        /// @param aDomain   The preference on which to listen for changes. This can
        /// be the name of an entire branch to observe.
        /// e.g. Holding the "root" prefbranch and calling
        /// addObserver("foo.bar.", ...) will observe changes to
        /// foo.bar.baz and foo.bar.bzip
        /// @param aObserver The object to be notified if the preference changes.
        /// @param aHoldWeak true  Hold a weak reference to |aObserver|. The object
        /// must implement the nsISupportsWeakReference
        /// interface or this will fail.
        /// false Hold a strong reference to |aObserver|.
        ///
        /// @note
        /// Registering as a preference observer can open an object to potential
        /// cyclical references which will cause memory leaks. These cycles generally
        /// occur because an object both registers itself as an observer (causing the
        /// branch to hold a reference to the observer) and holds a reference to the
        /// branch object for the purpose of getting/setting preference values. There
        /// are 3 approaches which have been implemented in an attempt to avoid these
        /// situations.
        /// 1) The nsPrefBranch object supports nsISupportsWeakReference. Any consumer
        /// may hold a weak reference to it instead of a strong one.
        /// 2) The nsPrefBranch object listens for xpcom-shutdown and frees all of the
        /// objects currently in its observer list. This ensures that long lived
        /// objects (services for example) will be freed correctly.
        /// 3) The observer can request to be held as a weak reference when it is
        /// registered. This insures that shorter lived objects (say one tied to an
        /// open window) will not fall into the cyclical reference trap.
        ///
        /// @note
        /// The list of registered observers may be changed during the dispatch of
        /// nsPref:changed notification. However, the observers are not guaranteed
        /// to be notified in any particular order, so you can't be sure whether the
        /// added/removed observer will be called during the notification when it
        /// is added/removed.
        ///
        /// @note
        /// It is possible to change preferences during the notification.
        ///
        /// @note
        /// It is not safe to change observers during this callback in Gecko
        /// releases before 1.9. If you want a safe way to remove a pref observer,
        /// please use an nsITimer.
        ///
        /// @see nsIObserver
        /// @see removeObserver
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddObserver([MarshalAs(UnmanagedType.LPStr)] string aDomain, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver, [MarshalAs(UnmanagedType.U1)] bool aHoldWeak);
		
		/// <summary>
        /// Remove a preference change observer.
        ///
        /// @param aDomain   The preference which is being observed for changes.
        /// @param aObserver An observer previously registered with addObserver().
        ///
        /// @note
        /// Note that you must call removeObserver() on the same nsIPrefBranch
        /// instance on which you called addObserver() in order to remove aObserver;
        /// otherwise, the observer will not be removed.
        ///
        /// @see nsIObserver
        /// @see addObserver
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveObserver([MarshalAs(UnmanagedType.LPStr)] string aDomain, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);
	}
}
