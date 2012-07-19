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
// Generated by IDLImporter from file nsIChannelEventSink.idl
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
    /// Implement this interface to receive control over various channel events.
    /// Channels will try to get this interface from a channel's
    /// notificationCallbacks or, if not available there, from the loadGroup's
    /// notificationCallbacks.
    ///
    /// These methods are called before onStartRequest.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a430d870-df77-4502-9570-d46a8de33154")]
	public interface nsIChannelEventSink
	{
		
		/// <summary>
        /// Called when a redirect occurs. This may happen due to an HTTP 3xx status
        /// code. The purpose of this method is to notify the sink that a redirect
        /// is about to happen, but also to give the sink the right to veto the
        /// redirect by throwing or passing a failure-code in the callback.
        ///
        /// Note that vetoing the redirect simply means that |newChannel| will not
        /// be opened. It is important to understand that |oldChannel| will continue
        /// loading as if it received a HTTP 200, which includes notifying observers
        /// and possibly display or process content attached to the HTTP response.
        /// If the sink wants to prevent this loading it must explicitly deal with
        /// it, e.g. by calling |oldChannel->Cancel()|
        ///
        /// There is a certain freedom in implementing this method:
        ///
        /// If the return-value indicates success, a callback on |callback| is
        /// required. This callback can be done from within asyncOnChannelRedirect
        /// (effectively making the call synchronous) or at some point later
        /// (making the call asynchronous). Repeat: A callback must be done
        /// if this method returns successfully.
        ///
        /// If the return value indicates error (method throws an exception)
        /// the redirect is vetoed and no callback must be done. Repeat: No
        /// callback must be done if this method throws!
        ///
        /// @see nsIAsyncVerifyRedirectCallback::onRedirectVerifyCallback()
        ///
        /// @param oldChannel
        /// The channel that's being redirected.
        /// @param newChannel
        /// The new channel. This channel is not opened yet.
        /// @param flags
        /// Flags indicating the type of redirect. A bitmask consisting
        /// of flags from above.
        /// One of REDIRECT_TEMPORARY and REDIRECT_PERMANENT will always be
        /// set.
        /// @param callback
        /// Object to inform about the async result of this method
        ///
        /// @throw <any> Throwing an exception will cause the redirect to be
        /// cancelled
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncOnChannelRedirect([MarshalAs(UnmanagedType.Interface)] nsIChannel oldChannel, [MarshalAs(UnmanagedType.Interface)] nsIChannel newChannel, uint flags, [MarshalAs(UnmanagedType.Interface)] nsIAsyncVerifyRedirectCallback callback);
	}
	
	/// <summary>nsIChannelEventSinkConsts </summary>
	public class nsIChannelEventSinkConsts
	{
		
		// <summary>
        // This is a temporary redirect. New requests for this resource should
        // continue to use the URI of the old channel.
        //
        // The new URI may be identical to the old one.
        // </summary>
		public const ulong REDIRECT_TEMPORARY = 1<<0;
		
		// <summary>
        // This is a permanent redirect. New requests for this resource should use
        // the URI of the new channel (This might be an HTTP 301 reponse).
        // If this flag is not set, this is a temporary redirect.
        //
        // The new URI may be identical to the old one.
        // </summary>
		public const ulong REDIRECT_PERMANENT = 1<<1;
		
		// <summary>
        // This is an internal redirect, i.e. it was not initiated by the remote
        // server, but is specific to the channel implementation.
        //
        // The new URI may be identical to the old one.
        // </summary>
		public const ulong REDIRECT_INTERNAL = 1<<2;
	}
}
