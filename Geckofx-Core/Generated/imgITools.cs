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
// Generated by IDLImporter from file imgITools.idl
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
    ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4c2383a4-931c-484d-8c4a-973590f66e3f")]
	public interface imgITools
	{
		
		/// <summary>
        /// decodeImage
        /// Caller provides an input stream and mimetype. We read from the stream
        /// and decompress it (according to the specified mime type) and return
        /// the resulting imgIContainer.
        ///
        /// @param aStream
        /// An input stream for an encoded image file.
        /// @param aMimeType
        /// Type of image in the stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIContainer DecodeImage([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType);
		
		/// <summary>
        /// decodeImageData
        /// Caller provides an input stream and mimetype. We read from the stream
        /// and decompress it (according to the specified mime type) and return
        /// the resulting imgIContainer.
        ///
        /// This method is deprecated and will be removed at some time in the future;
        /// new code should use |decodeImage|.
        ///
        /// @param aStream
        /// An input stream for an encoded image file.
        /// @param aMimeType
        /// Type of image in the stream.
        /// @param aContainer
        /// An imgIContainer holding the decoded image will be returned via
        /// this parameter. It is an error to provide any initial value but
        /// |null|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecodeImageData([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, ref imgIContainer aContainer);
		
		/// <summary>
        /// encodeImage
        /// Caller provides an image container, and the mime type it should be
        /// encoded to. We return an input stream for the encoded image data.
        ///
        /// @param aContainer
        /// An image container.
        /// @param aMimeType
        /// Type of encoded image desired (eg "image/png").
        /// @param outputOptions
        /// Encoder-specific output options.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream EncodeImage(imgIContainer aContainer, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase outputOptions);
		
		/// <summary>
        /// encodeScaledImage
        /// Caller provides an image container, and the mime type it should be
        /// encoded to. We return an input stream for the encoded image data.
        /// The encoded image is scaled to the specified dimensions.
        ///
        /// @param aContainer
        /// An image container.
        /// @param aMimeType
        /// Type of encoded image desired (eg "image/png").
        /// @param aWidth, aHeight
        /// The size (in pixels) desired for the resulting image. Specify 0 to
        /// use the given image's width or height. Values must be >= 0.
        /// @param outputOptions
        /// Encoder-specific output options.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream EncodeScaledImage(imgIContainer aContainer, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, int aWidth, int aHeight, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase outputOptions);
		
		/// <summary>
        /// getImgLoaderForDocument
        /// Retrieve an image loader that reflects the privacy status of the given
        /// document.
        ///
        /// @param doc
        /// A document. Must not be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgILoader GetImgLoaderForDocument([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc);
		
		/// <summary>
        /// getImgLoaderForDocument
        /// Retrieve an image cache that reflects the privacy status of the given
        /// document.
        ///
        /// @param doc
        /// A document. Null is allowed, but must _only_ be passed
        /// when there is no way to obtain a relevant document for
        /// the current context in which a cache is desired.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgICache GetImgCacheForDocument([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc);
		
		/// <summary>
        /// encodeCroppedImage
        /// Caller provides an image container, and the mime type it should be
        /// encoded to. We return an input stream for the encoded image data.
        /// The encoded image is cropped to the specified dimensions.
        ///
        /// The given offset and size must not exceed the image bounds.
        ///
        /// @param aContainer
        /// An image container.
        /// @param aMimeType
        /// Type of encoded image desired (eg "image/png").
        /// @param aOffsetX, aOffsetY
        /// The crop offset (in pixels). Values must be >= 0.
        /// @param aWidth, aHeight
        /// The size (in pixels) desired for the resulting image. Specify 0 to
        /// use the given image's width or height. Values must be >= 0.
        /// @param outputOptions
        /// Encoder-specific output options.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream EncodeCroppedImage(imgIContainer aContainer, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, int aOffsetX, int aOffsetY, int aWidth, int aHeight, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase outputOptions);
		
		/// <summary>
        /// Create a wrapper around a scripted notification observer (ordinarily
        /// imgINotificationObserver cannot be implemented from scripts).
        ///
        /// @param aObserver The scripted observer to wrap
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgINotificationObserver CreateScriptedObserver(imgIScriptedNotificationObserver aObserver);
	}
}
