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
// Generated by IDLImporter from file nsIThread.idl
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
    /// This interface provides a high-level abstraction for an operating system
    /// thread.
    ///
    /// Threads have a built-in event queue, and a thread is an event target that
    /// can receive nsIRunnable objects (events) to be processed on the thread.
    ///
    /// See nsIThreadManager for the API used to create and locate threads.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9c889946-a73a-4af3-ae9a-ea64f7d4e3ca")]
	public interface nsIThread : nsIEventTarget
	{
		
		/// <summary>
        /// Dispatch an event to this event target.  This function may be called from
        /// any thread, and it may be called re-entrantly.
        ///
        /// @param event
        /// The event to dispatch.
        /// @param flags
        /// The flags modifying event dispatch.  The flags are described in detail
        /// below.
        ///
        /// @throws NS_ERROR_INVALID_ARG
        /// Indicates that event is null.
        /// @throws NS_ERROR_UNEXPECTED
        /// Indicates that the thread is shutting down and has finished processing
        /// events, so this event would never run and has not been dispatched.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Dispatch([MarshalAs(UnmanagedType.Interface)] nsIRunnable @event, uint flags);
		
		/// <summary>
        /// Check to see if this event target is associated with the current thread.
        ///
        /// @returns
        /// A boolean value that if "true" indicates that events dispatched to this
        /// event target will run on the current thread (i.e., the thread calling
        /// this method).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsOnCurrentThread();
		
		/// <summary>
        /// @returns
        /// The NSPR thread object corresponding to this nsIThread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPRThreadAttribute();
		
		/// <summary>
        /// Shutdown the thread.  This method prevents further dispatch of events to
        /// the thread, and it causes any pending events to run to completion before
        /// the thread joins (see PR_JoinThread) with the current thread.  During this
        /// method call, events for the current thread may be processed.
        ///
        /// This method MAY NOT be executed from the thread itself.  Instead, it is
        /// meant to be executed from another thread (usually the thread that created
        /// this thread or the main application thread).  When this function returns,
        /// the thread will be shutdown, and it will no longer be possible to dispatch
        /// events to the thread.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// Indicates that this method was erroneously called when this thread was
        /// the current thread, that this thread was not created with a call to
        /// nsIThreadManager::NewThread, or if this method was called more than once
        /// on the thread object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
		
		/// <summary>
        /// This method may be called to determine if there are any events ready to be
        /// processed.  It may only be called when this thread is the current thread.
        ///
        /// Because events may be added to this thread by another thread, a "false"
        /// result does not mean that this thread has no pending events.  It only
        /// means that there were no pending events when this method was called.
        ///
        /// @returns
        /// A boolean value that if "true" indicates that this thread has one or
        /// more pending events.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// Indicates that this method was erroneously called when this thread was
        /// not the current thread.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasPendingEvents();
		
		/// <summary>
        /// Process the next event.  If there are no pending events, then this method
        /// may wait -- depending on the value of the mayWait parameter -- until an
        /// event is dispatched to this thread.  This method is re-entrant but may
        /// only be called if this thread is the current thread.
        ///
        /// @param mayWait
        /// A boolean parameter that if "true" indicates that the method may block
        /// the calling thread to wait for a pending event.
        ///
        /// @returns
        /// A boolean value that if "true" indicates that an event was processed.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// Indicates that this method was erroneously called when this thread was
        /// not the current thread.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ProcessNextEvent([MarshalAs(UnmanagedType.Bool)] bool mayWait);
	}
}
