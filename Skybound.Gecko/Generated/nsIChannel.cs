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
// Generated by IDLImporter from file nsIChannel.idl
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
    /// The nsIChannel interface allows clients to construct "GET" requests for
    /// specific protocols, and manage them in a uniform way.  Once a channel is
    /// created (via nsIIOService::newChannel), parameters for that request may
    /// be set by using the channel attributes, or by QI'ing to a subclass of
    /// nsIChannel for protocol-specific parameters.  Then, the URI can be fetched
    /// by calling nsIChannel::open or nsIChannel::asyncOpen.
    ///
    /// After a request has been completed, the channel is still valid for accessing
    /// protocol-specific results.  For example, QI'ing to nsIHttpChannel allows
    /// response headers to be retrieved for the corresponding http transaction.
    ///
    /// This interface must be used only from the XPCOM main thread.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("06f6ada3-7729-4e72-8d3f-bf8ba630ff9b")]
	public interface nsIChannel : nsIRequest
	{
		
		/// <summary>
        /// The name of the request.  Often this is the URI of the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Indicates whether the request is pending. nsIRequest::isPending is
        /// true when there is an outstanding asynchronous event that will make
        /// the request no longer be pending.  Requests do not necessarily start
        /// out pending; in some cases, requests have to be explicitly initiated
        /// (e.g. nsIChannel implementations are only pending once asyncOpen
        /// returns successfully).
        ///
        /// Requests can become pending multiple times during their lifetime.
        ///
        /// @return TRUE if the request has yet to reach completion.
        /// @return FALSE if the request has reached completion (e.g., after
        /// OnStopRequest has fired).
        /// @note Suspended requests are still considered pending.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsPending();
		
		/// <summary>
        /// The error status associated with the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetStatusAttribute();
		
		/// <summary>
        /// Cancels the current request.  This will close any open input or
        /// output streams and terminate any async requests.  Users should
        /// normally pass NS_BINDING_ABORTED, although other errors may also
        /// be passed.  The error passed in will become the value of the
        /// status attribute.
        ///
        /// Implementations must not send any notifications (e.g. via
        /// nsIRequestObserver) synchronously from this function. Similarly,
        /// removal from the load group (if any) must also happen asynchronously.
        ///
        /// Requests that use nsIStreamListener must not call onDataAvailable
        /// anymore after cancel has been called.
        ///
        /// @param aStatus the reason for canceling this request.
        ///
        /// NOTE: most nsIRequest implementations expect aStatus to be a
        /// failure code; however, some implementations may allow aStatus to
        /// be a success code such as NS_OK.  In general, aStatus should be
        /// a failure code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Cancel(int aStatus);
		
		/// <summary>
        /// Suspends the current request.  This may have the effect of closing
        /// any underlying transport (in order to free up resources), although
        /// any open streams remain logically opened and will continue delivering
        /// data when the transport is resumed.
        ///
        /// Calling cancel() on a suspended request must not send any
        /// notifications (such as onstopRequest) until the request is resumed.
        ///
        /// NOTE: some implementations are unable to immediately suspend, and
        /// may continue to deliver events already posted to an event queue. In
        /// general, callers should be capable of handling events even after
        /// suspending a request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Suspend();
		
		/// <summary>
        /// Resumes the current request.  This may have the effect of re-opening
        /// any underlying transport and will resume the delivery of data to
        /// any open streams.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Resume();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsILoadGroup GetLoadGroupAttribute();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetLoadFlagsAttribute();
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadFlagsAttribute(uint aLoadFlags);
		
		/// <summary>
        /// The original URI used to construct the channel. This is used in
        /// the case of a redirect or URI "resolution" (e.g. resolving a
        /// resource: URI to a file: URI) so that the original pre-redirect
        /// URI can still be obtained.  This is never null.  Attempts to
        /// set it to null must throw.
        ///
        /// NOTE: this is distinctly different from the http Referer (referring URI),
        /// which is typically the page that contained the original URI (accessible
        /// from nsIHttpChannel).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetOriginalURIAttribute();
		
		/// <summary>
        /// The original URI used to construct the channel. This is used in
        /// the case of a redirect or URI "resolution" (e.g. resolving a
        /// resource: URI to a file: URI) so that the original pre-redirect
        /// URI can still be obtained.  This is never null.  Attempts to
        /// set it to null must throw.
        ///
        /// NOTE: this is distinctly different from the http Referer (referring URI),
        /// which is typically the page that contained the original URI (accessible
        /// from nsIHttpChannel).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);
		
		/// <summary>
        /// The URI corresponding to the channel.  Its value is immutable.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// The owner, corresponding to the entity that is responsible for this
        /// channel.  Used by the security manager to grant or deny privileges to
        /// mobile code loaded from this channel.
        ///
        /// NOTE: this is a strong reference to the owner, so if the owner is also
        /// holding a strong reference to the channel, care must be taken to
        /// explicitly drop its reference to the channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetOwnerAttribute();
		
		/// <summary>
        /// The owner, corresponding to the entity that is responsible for this
        /// channel.  Used by the security manager to grant or deny privileges to
        /// mobile code loaded from this channel.
        ///
        /// NOTE: this is a strong reference to the owner, so if the owner is also
        /// holding a strong reference to the channel, care must be taken to
        /// explicitly drop its reference to the channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);
		
		/// <summary>
        /// The notification callbacks for the channel.  This is set by clients, who
        /// wish to provide a means to receive progress, status and protocol-specific
        /// notifications.  If this value is NULL, the channel implementation may use
        /// the notification callbacks from its load group.  The channel may also
        /// query the notification callbacks from its load group if its notification
        /// callbacks do not supply the requested interface.
        ///
        /// Interfaces commonly requested include: nsIProgressEventSink, nsIPrompt,
        /// and nsIAuthPrompt/nsIAuthPrompt2.
        ///
        /// When the channel is done, it must not continue holding references to
        /// this object.
        ///
        /// NOTE: A channel implementation should take care when "caching" an
        /// interface pointer queried from its notification callbacks.  If the
        /// notification callbacks are changed, then a cached interface pointer may
        /// become invalid and may therefore need to be re-queried.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceRequestor GetNotificationCallbacksAttribute();
		
		/// <summary>
        /// The notification callbacks for the channel.  This is set by clients, who
        /// wish to provide a means to receive progress, status and protocol-specific
        /// notifications.  If this value is NULL, the channel implementation may use
        /// the notification callbacks from its load group.  The channel may also
        /// query the notification callbacks from its load group if its notification
        /// callbacks do not supply the requested interface.
        ///
        /// Interfaces commonly requested include: nsIProgressEventSink, nsIPrompt,
        /// and nsIAuthPrompt/nsIAuthPrompt2.
        ///
        /// When the channel is done, it must not continue holding references to
        /// this object.
        ///
        /// NOTE: A channel implementation should take care when "caching" an
        /// interface pointer queried from its notification callbacks.  If the
        /// notification callbacks are changed, then a cached interface pointer may
        /// become invalid and may therefore need to be re-queried.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);
		
		/// <summary>
        /// Transport-level security information (if any) corresponding to the channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetSecurityInfoAttribute();
		
		/// <summary>
        /// The MIME type of the channel's content if available.
        ///
        /// NOTE: the content type can often be wrongly specified (e.g., wrong file
        /// extension, wrong MIME type, wrong document type stored on a server, etc.),
        /// and the caller most likely wants to verify with the actual data.
        ///
        /// Setting contentType before the channel has been opened provides a hint
        /// to the channel as to what the MIME type is.  The channel may ignore this
        /// hint in deciding on the actual MIME type that it will report.
        ///
        /// Setting contentType after onStartRequest has been fired or after open()
        /// is called will override the type determined by the channel.
        ///
        /// Setting contentType between the time that asyncOpen() is called and the
        /// time when onStartRequest is fired has undefined behavior at this time.
        ///
        /// The value of the contentType attribute is a lowercase string.  A value
        /// assigned to this attribute will be parsed and normalized as follows:
        /// 1- any parameters (delimited with a ';') will be stripped.
        /// 2- if a charset parameter is given, then its value will replace the
        /// the contentCharset attribute of the channel.
        /// 3- the stripped contentType will be lowercased.
        /// Any implementation of nsIChannel must follow these rules.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);
		
		/// <summary>
        /// The MIME type of the channel's content if available.
        ///
        /// NOTE: the content type can often be wrongly specified (e.g., wrong file
        /// extension, wrong MIME type, wrong document type stored on a server, etc.),
        /// and the caller most likely wants to verify with the actual data.
        ///
        /// Setting contentType before the channel has been opened provides a hint
        /// to the channel as to what the MIME type is.  The channel may ignore this
        /// hint in deciding on the actual MIME type that it will report.
        ///
        /// Setting contentType after onStartRequest has been fired or after open()
        /// is called will override the type determined by the channel.
        ///
        /// Setting contentType between the time that asyncOpen() is called and the
        /// time when onStartRequest is fired has undefined behavior at this time.
        ///
        /// The value of the contentType attribute is a lowercase string.  A value
        /// assigned to this attribute will be parsed and normalized as follows:
        /// 1- any parameters (delimited with a ';') will be stripped.
        /// 2- if a charset parameter is given, then its value will replace the
        /// the contentCharset attribute of the channel.
        /// 3- the stripped contentType will be lowercased.
        /// Any implementation of nsIChannel must follow these rules.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);
		
		/// <summary>
        /// The character set of the channel's content if available and if applicable.
        /// This attribute only applies to textual data.
        ///
        /// The value of the contentCharset attribute is a mixedcase string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentCharset);
		
		/// <summary>
        /// The character set of the channel's content if available and if applicable.
        /// This attribute only applies to textual data.
        ///
        /// The value of the contentCharset attribute is a mixedcase string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentCharset);
		
		/// <summary>
        /// The length of the data associated with the channel if available.  A value
        /// of -1 indicates that the content length is unknown.
        ///
        /// Callers should prefer getting the "content-length" property
        /// as 64-bit value by QIing the channel to nsIPropertyBag2,
        /// if that interface is exposed by the channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetContentLengthAttribute();
		
		/// <summary>
        /// The length of the data associated with the channel if available.  A value
        /// of -1 indicates that the content length is unknown.
        ///
        /// Callers should prefer getting the "content-length" property
        /// as 64-bit value by QIing the channel to nsIPropertyBag2,
        /// if that interface is exposed by the channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentLengthAttribute(int aContentLength);
		
		/// <summary>
        /// Synchronously open the channel.
        ///
        /// @return blocking input stream to the channel's data.
        ///
        /// NOTE: nsIChannel implementations are not required to implement this
        /// method.  Moreover, since this method may block the calling thread, it
        /// should not be called on a thread that processes UI events.  Like any
        /// other nsIChannel method it must not be called on any thread other
        /// than the XPCOM main thread.
        ///
        /// NOTE: Implementations should throw NS_ERROR_IN_PROGRESS if the channel
        /// is reopened.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream Open();
		
		/// <summary>
        /// Asynchronously open this channel.  Data is fed to the specified stream
        /// listener as it becomes available.  The stream listener's methods are
        /// called on the thread that calls asyncOpen and are not called until
        /// after asyncOpen returns.  If asyncOpen returns successfully, the
        /// channel promises to call at least onStartRequest and onStopRequest.
        ///
        /// If the nsIRequest object passed to the stream listener's methods is not
        /// this channel, an appropriate onChannelRedirect notification needs to be
        /// sent to the notification callbacks before onStartRequest is called.
        /// Once onStartRequest is called, all following method calls on aListener
        /// will get the request that was passed to onStartRequest.
        ///
        /// If the channel's and loadgroup's notification callbacks do not provide
        /// an nsIChannelEventSink when onChannelRedirect would be called, that's
        /// equivalent to having called onChannelRedirect.
        ///
        /// If asyncOpen returns successfully, the channel is responsible for
        /// keeping itself alive until it has called onStopRequest on aListener or
        /// called onChannelRedirect.
        ///
        /// Implementations are allowed to synchronously add themselves to the
        /// associated load group (if any).
        ///
        /// NOTE: Implementations should throw NS_ERROR_ALREADY_OPENED if the
        /// channel is reopened.
        ///
        /// @param aListener the nsIStreamListener implementation
        /// @param aContext an opaque parameter forwarded to aListener's methods
        /// @see nsIChannelEventSink for onChannelRedirect
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Access to the type implied or stated by the Content-Disposition header
        /// if available and if applicable. This allows determining inline versus
        /// attachment.
        ///
        /// Implementations should throw NS_ERROR_NOT_AVAILABLE if the header either
        /// doesn't exist for this type of channel or is empty, and
        /// DISPOSITION_ATTACHMENT if an invalid/noncompliant value is present.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetContentDispositionAttribute();
		
		/// <summary>
        /// Access to the filename portion of the Content-Disposition header if
        /// available and if applicable. This allows getting the preferred filename
        /// without having to parse it out yourself.
        ///
        /// Implementations should throw NS_ERROR_NOT_AVAILABLE if the header doesn't
        /// exist for this type of channel, if the header is empty, if the header
        /// doesn't contain a filename portion, or the value of the filename
        /// attribute is empty/missing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentDispositionFilenameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentDispositionFilename);
		
		/// <summary>
        /// Access to the raw Content-Disposition header if available and applicable.
        ///
        /// Implementations should throw NS_ERROR_NOT_AVAILABLE if the header either
        /// doesn't exist for this type of channel or is empty.
        ///
        /// @deprecated Use contentDisposition/contentDispositionFilename instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentDispositionHeaderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentDispositionHeader);
	}
}
