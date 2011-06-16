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
// Generated by IDLImporter from file imgIDecoderObserver.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// imgIDecoderObserver interface
    ///
    /// This interface is used both for observing imgIDecoder objects and for
    /// observing imgIRequest objects.  In the former case, aRequest is
    /// always null.
    ///
    /// We make the distinction here between "load" and "decode" notifications. Load
    /// notifications are fired as the image is loaded from the network or
    /// filesystem. Decode notifications are fired as the image is decoded. If an
    /// image is decoded on load and not visibly discarded, decode notifications are
    /// nested logically inside load notifications as one might expect. However, with
    /// decode-on-draw, the set of decode notifications can come completely _after_
    /// the load notifications, and can come multiple times if the image is
    /// discardable. Moreover, they can be interleaved in various ways. In general,
    /// any presumed ordering between load and decode notifications should not be
    /// relied upon.
    ///
    /// Decode notifications may or may not be synchronous, depending on the
    /// situation. If imgIDecoder::FLAG_SYNC_DECODE is passed to a function that
    /// triggers a decode, all notifications that can be generated from the currently
    /// loaded data fire before the call returns. If FLAG_SYNC_DECODE is not passed,
    /// all, some, or none of the notifications may fire before the call returns.
    ///
    /// This interface will be cleaned up in bug 505385.
    ///
    /// @author Stuart Parmenter <pavlov@netscape.com>
    /// @version 0.1
    /// @see imagelib2
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9f6bfbee-9e04-43a0-b8f6-2159973efec8")]
	public interface imgIDecoderObserver : imgIContainerObserver
	{
		
		/// <summary>
        /// imgIContainerObserver interface
        ///
        /// @author Stuart Parmenter <pavlov@netscape.com>
        /// @version 0.1
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void FrameChanged(imgIContainer aContainer, [MarshalAs(UnmanagedType.Interface)] nsIntRect aDirtyRect);
		
		/// <summary>
        /// Load notification.
        ///
        /// called at the same time that nsIRequestObserver::onStartRequest would be
        /// (used only for observers of imgIRequest objects, which are nsIRequests,
        /// not imgIDecoder objects)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStartRequest(imgIRequest aRequest);
		
		/// <summary>
        /// Decode notification.
        ///
        /// Called as soon as the image begins getting decoded. This does not include
        /// "header-only" decodes used by decode-on-draw to parse the width/height
        /// out of the image. Thus, it is a decode notification only.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStartDecode(imgIRequest aRequest);
		
		/// <summary>
        /// Load notification.
        ///
        /// Called once enough data has been loaded from the network that we were able
        /// to parse the width/height from the image. By the time this callback is been
        /// called, the size has been set on the container and STATUS_SIZE_AVAILABLE
        /// has been set on the associated imgRequest.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStartContainer(imgIRequest aRequest, imgIContainer aContainer);
		
		/// <summary>
        /// Decode notification.
        ///
        /// called when each frame is created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStartFrame(imgIRequest aRequest, uint aFrame);
		
		/// <summary>
        /// Decode notification.
        ///
        /// called when there is more to paint.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDataAvailable(imgIRequest aRequest, [MarshalAs(UnmanagedType.Bool)] bool aCurrentFrame, [MarshalAs(UnmanagedType.Interface)] nsIntRect aRect);
		
		/// <summary>
        /// Decode notification.
        ///
        /// called when a frame is finished decoding.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStopFrame(imgIRequest aRequest, uint aFrame);
		
		/// <summary>
        /// Do not implement this. It is useless and going away.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStopContainer(imgIRequest aRequest, imgIContainer aContainer);
		
		/// <summary>
        /// In theory a decode notification, but currently a load notification.
        ///
        /// Ideally this would be called when the decode is complete. Unfortunately,
        /// this is currently the only way to signal decoding errors to consumers,
        /// and the only decoding errors that consumers care about (indeed, the only
        /// ones that they're prepared to hear about) are failures to instantiate the
        /// decoder (<img src="foo.html"> for example). Thus, currently this is just
        /// a companion to onStopDecode to signal success or failure. This will be
        /// revisited in bug 505385. If you're thinking of doing something new with
        /// this, please talk to bholley first.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStopDecode(imgIRequest aRequest, int status, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string statusArg);
		
		/// <summary>
        /// Load notification.
        ///
        /// called at the same time that nsIRequestObserver::onStopRequest would be
        /// (used only for observers of imgIRequest objects, which are nsIRequests,
        /// not imgIDecoder objects)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStopRequest(imgIRequest aRequest, [MarshalAs(UnmanagedType.Bool)] bool aIsLastPart);
		
		/// <summary>
        /// Called when the decoded image data is discarded. This means that the frames
        /// no longer exist in decoded form, and any attempt to access or draw the
        /// image will initiate a new series of progressive decode notifications.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDiscard(imgIRequest aRequest);
	}
}
