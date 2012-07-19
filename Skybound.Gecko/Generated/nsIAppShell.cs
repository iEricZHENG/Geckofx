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
// Generated by IDLImporter from file nsIAppShell.idl
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
    /// Interface for the native event system layer.  This interface is designed
    /// to be used on the main application thread only.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("40bc6280-ad83-471e-b197-80ab90e2065e")]
	public interface nsIAppShell
	{
		
		/// <summary>
        /// Enter an event loop.  Don't leave until exit() is called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Run();
		
		/// <summary>
        /// Exit the handle event loop
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Exit();
		
		/// <summary>
        /// Give hint to native event queue notification mechanism. If the native
        /// platform needs to tradeoff performance vs. native event starvation this
        /// hint tells the native dispatch code which to favor.  The default is to
        /// prevent native event starvation.
        ///
        /// Calls to this function may be nested. When the number of calls that pass
        /// PR_TRUE is subtracted from the number of calls that pass PR_FALSE is
        /// greater than 0, performance is given precedence over preventing event
        /// starvation.
        ///
        /// The starvationDelay arg is only used when favorPerfOverStarvation is
        /// PR_FALSE. It is the amount of time in milliseconds to wait before the
        /// PR_FALSE actually takes effect.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FavorPerformanceHint([MarshalAs(UnmanagedType.U1)] bool favorPerfOverStarvation, uint starvationDelay);
		
		/// <summary>
        /// Suspends the use of additional platform-specific methods (besides the
        /// nsIAppShell->run() event loop) to run Gecko events on the main
        /// application thread.  Under some circumstances these "additional methods"
        /// can cause Gecko event handlers to be re-entered, sometimes leading to
        /// hangs and crashes.  Calls to suspendNative() and resumeNative() may be
        /// nested.  On some platforms (those that don't use any "additional
        /// methods") this will be a no-op.  Does not (in itself) stop Gecko events
        /// from being processed on the main application thread.  But if the
        /// nsIAppShell->run() event loop is blocked when this call is made, Gecko
        /// events will stop being processed until resumeNative() is called (even
        /// if a plugin or library is temporarily processing events on a nested
        /// event loop).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SuspendNative();
		
		/// <summary>
        /// Resumes the use of additional platform-specific methods to run Gecko
        /// events on the main application thread.  Calls to suspendNative() and
        /// resumeNative() may be nested.  On some platforms this will be a no-op.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeNative();
		
		/// <summary>
        /// The current event loop nesting level.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetEventloopNestingLevelAttribute();
		
		/// <summary>
        /// Allows running of a "synchronous section", in the form of an nsIRunnable
        /// once the event loop has reached a "stable state". We've reached a stable
        /// state when the currently executing task/event has finished, see:
        /// http://www.whatwg.org/specs/web-apps/current-work/multipage/webappapis.html#synchronous-section
        /// In practice this runs aRunnable once the currently executing event
        /// finishes. If called multiple times per task/event, all the runnables will
        /// be executed, in the order in which runInStableState() was called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RunInStableState([MarshalAs(UnmanagedType.Interface)] nsIRunnable aRunnable);
	}
}
