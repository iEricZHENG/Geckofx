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
// Generated by IDLImporter from file nsIThreadPool.idl
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
	[Guid("ef194cab-3f86-4b61-b132-e5e96a79e5d1")]
	public interface nsIThreadPoolListener
	{
		
		/// <summary>
        /// Called when a new thread is created by the thread pool. The notification
        /// happens on the newly-created thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnThreadCreated();
		
		/// <summary>
        /// Called when a thread is about to be destroyed by the thread pool. The
        /// notification happens on the thread that is about to be destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnThreadShuttingDown();
	}
	
	/// <summary>
    /// An interface to a thread pool.  A thread pool creates a limited number of
    /// anonymous (unnamed) worker threads.  An event dispatched to the thread pool
    /// will be run on the next available worker thread.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ba9a466b-8d4a-4b33-ae5c-6ed751068c90")]
	public interface nsIThreadPool : nsIEventTarget
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
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsOnCurrentThread();
		
		/// <summary>
        /// Shutdown the thread pool.  This method may not be executed from any thread
        /// in the thread pool.  Instead, it is meant to be executed from another
        /// thread (usually the thread that created this thread pool).  When this
        /// function returns, the thread pool and all of its threads will be shutdown,
        /// and it will no longer be possible to dispatch tasks to the thread pool.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
		
		/// <summary>
        /// Get/set the maximum number of threads allowed at one time in this pool.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetThreadLimitAttribute();
		
		/// <summary>
        /// Get/set the maximum number of threads allowed at one time in this pool.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetThreadLimitAttribute(uint aThreadLimit);
		
		/// <summary>
        /// Get/set the maximum number of idle threads kept alive.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetIdleThreadLimitAttribute();
		
		/// <summary>
        /// Get/set the maximum number of idle threads kept alive.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIdleThreadLimitAttribute(uint aIdleThreadLimit);
		
		/// <summary>
        /// Get/set the amount of time in milliseconds before an idle thread is
        /// destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetIdleThreadTimeoutAttribute();
		
		/// <summary>
        /// Get/set the amount of time in milliseconds before an idle thread is
        /// destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIdleThreadTimeoutAttribute(uint aIdleThreadTimeout);
		
		/// <summary>
        /// An optional listener that will be notified when a thread is created or
        /// destroyed in the course of the thread pool's operation.
        ///
        /// A listener will only receive notifications about threads created after the
        /// listener is set so it is recommended that the consumer set the listener
        /// before dispatching the first event. A listener that receives an
        /// onThreadCreated() notification is guaranteed to always receive the
        /// corresponding onThreadShuttingDown() notification.
        ///
        /// The thread pool takes ownership of the listener and releases it when the
        /// shutdown() method is called. Threads created after the listener is set will
        /// also take ownership of the listener so that the listener will be kept alive
        /// long enough to receive the guaranteed onThreadShuttingDown() notification.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIThreadPoolListener GetListenerAttribute();
		
		/// <summary>
        /// An optional listener that will be notified when a thread is created or
        /// destroyed in the course of the thread pool's operation.
        ///
        /// A listener will only receive notifications about threads created after the
        /// listener is set so it is recommended that the consumer set the listener
        /// before dispatching the first event. A listener that receives an
        /// onThreadCreated() notification is guaranteed to always receive the
        /// corresponding onThreadShuttingDown() notification.
        ///
        /// The thread pool takes ownership of the listener and releases it when the
        /// shutdown() method is called. Threads created after the listener is set will
        /// also take ownership of the listener so that the listener will be kept alive
        /// long enough to receive the guaranteed onThreadShuttingDown() notification.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIThreadPoolListener aListener);
		
		/// <summary>
        /// Set the label for threads in the pool. All threads will be named
        /// "<aName> #<n>", where <n> is a serial number.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetName([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);
	}
}
