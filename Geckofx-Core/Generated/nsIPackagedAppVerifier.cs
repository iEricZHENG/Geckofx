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
// Generated by IDLImporter from file nsIPackagedAppVerifier.idl
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
    /// nsIPackagedAppVerifier
    ///
    /// It inherits nsIStreamListener and all the data will be fed by
    /// onStartRequest/onDataAvailable/onStopRequest.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("37a5c208-0fce-4ad6-8431-aeb904dfe543")]
	public interface nsIPackagedAppVerifier : nsIStreamListener
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);
		
		/// <summary>
        /// attribute is empty.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPackageIdentifierAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPackageIdentifier);
		
		/// <summary>
        /// Whether this package is signed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsPackageSignedAttribute();
		
		/// <summary>
        /// @param aListener
        /// an object implementing nsIPackagedAppVerifierListener as the bridge that
        /// the client gets callback from the package verifier. The callback might be
        /// sync or async depending on the implementation.
        ///
        /// @param aPackageOrigin
        /// the origin of the package. It will be updated based on the package
        /// identifier defined in the manifest.
        ///
        /// @param aSignature
        /// the signature of the package we desire to verify against. See
        /// https://wiki.mozilla.org/User:Ptheriault/Packagedprivilegedcontent#The_Signed_Manifest
        /// for further information.
        ///
        /// @param aPackageCacheEntry
        /// the cache entry of the package itself (not the resource's cache).
        /// It will be used to store any necessary information like the signed
        /// package origin.
        ///
        /// The verifier init function.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIPackagedAppVerifierListener aListener, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPackageOrigin, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSignature, [MarshalAs(UnmanagedType.Interface)] nsICacheEntry aPackageCacheEntry);
		
		/// <summary>
        /// @param aUri
        /// the URI of the resource.
        ///
        /// @param aCacheEntry
        /// the cache entry of the resource.
        ///
        /// @param aStatusCode
        /// the status code of the resource we just finished download.
        ///
        /// @param aIsLastPart
        /// whether this resource is the last one in the package.
        ///
        /// Create an object that we will pass to the verifier as a user context
        /// through onStartRequest. The main purpose of this function is to make
        /// nsIPackagedAppVerifier xpcshell-testable. See test_packaged_app_verifier.js.
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports CreateResourceCacheInfo([MarshalAs(UnmanagedType.Interface)] nsIURI aUri, [MarshalAs(UnmanagedType.Interface)] nsICacheEntry aCacheEntry, int aStatusCode, [MarshalAs(UnmanagedType.U1)] bool aIsLastPart);
	}
	
	/// <summary>
    /// nsIPackagedAppVerifierListener
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("092eba70-4cbf-11e5-b970-0800200c9a66")]
	public interface nsIPackagedAppVerifierListener
	{
		
		/// <summary>
        /// @param aIsManifest
        /// indicate if this callback is for manifest or not. True for manifest and false
        /// for resource.
        ///
        /// @param aUri
        /// the URI of the resource that has just been verified.
        ///
        /// @param aCacheEntry
        /// the cache entry of the resource that has just been verified.
        ///
        /// @param aStatusCode
        /// the resource download status code from nsIMultipartChannel.
        ///
        /// @param aIsLastPart
        /// indicate if the verified resource is that last one in the package.
        ///
        /// @param aVerificationSuccess
        /// the verification result.
        ///
        /// Callback'ed when a manifest/resource is verified.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnVerified([MarshalAs(UnmanagedType.U1)] bool aIsManifest, [MarshalAs(UnmanagedType.Interface)] nsIURI aUri, [MarshalAs(UnmanagedType.Interface)] nsICacheEntry aCacheEntry, int aStatusCode, [MarshalAs(UnmanagedType.U1)] bool aIsLastPart, [MarshalAs(UnmanagedType.U1)] bool aVerificationSuccess);
	}
}