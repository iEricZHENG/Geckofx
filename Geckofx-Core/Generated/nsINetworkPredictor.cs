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
// Generated by IDLImporter from file nsINetworkPredictor.idl
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
    /// nsINetworkPredictor - learn about pages users visit, and allow us to take
    /// predictive actions upon future visits.
    /// NOTE: nsINetworkPredictor should only
    /// be used on the main thread.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("acc88e7c-3f39-42c7-ac31-6377c2c3d73e")]
	public interface nsINetworkPredictor
	{
		
		/// <summary>
        /// Start taking predictive actions
        ///
        /// Calling this will cause the predictor to (possibly) start
        /// taking actions such as DNS prefetch and/or TCP preconnect based on
        /// (1) the host name that we are given, and (2) the reason we are being
        /// asked to take actions.
        ///
        /// @param targetURI - The URI we are being asked to take actions based on.
        /// @param sourceURI - The URI that is currently loaded. This is so we can
        /// avoid doing predictive actions for link hover on an HTTPS page (for
        /// example).
        /// @param reason - The reason we are being asked to take actions. Can be
        /// any of the PREDICT_* values above.
        /// In the case of PREDICT_LINK, targetURI should be the URI of the link
        /// that is being hovered over, and sourceURI should be the URI of the page
        /// on which the link appears.
        /// In the case of PREDICT_LOAD, targetURI should be the URI of the page that
        /// is being loaded and sourceURI should be null.
        /// In the case of PREDICT_STARTUP, both targetURI and sourceURI should be
        /// null.
        /// @param loadContext - The nsILoadContext of the page load we are predicting
        /// about.
        /// @param verifier - An nsINetworkPredictorVerifier used in testing to ensure
        /// we're predicting the way we expect to. Not necessary (or desired) for
        /// normal operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Predict([MarshalAs(UnmanagedType.Interface)] nsIURI targetURI, [MarshalAs(UnmanagedType.Interface)] nsIURI sourceURI, PredictorPredictReason reason, [MarshalAs(UnmanagedType.Interface)] nsILoadContext loadContext, [MarshalAs(UnmanagedType.Interface)] nsINetworkPredictorVerifier verifier);
		
		/// <summary>
        /// Add to our compendium of knowledge
        ///
        /// This adds to our prediction database to make things (hopefully)
        /// smarter next time we predict something.
        ///
        /// @param targetURI - The URI that was loaded that we are keeping track of.
        /// @param sourceURI - The URI that caused targetURI to be loaded (for page
        /// loads). This means the DOCUMENT URI.
        /// @param reason - The reason we are learning this bit of knowledge.
        /// Reason can be any of the LEARN_* values.
        /// In the case of LEARN_LOAD_SUBRESOURCE, targetURI should be the URI of a
        /// subresource of a page, and sourceURI should be the top-level URI.
        /// In the case of LEARN_LOAD_REDIRECT, targetURI is the NEW URI of a
        /// top-level resource that was redirected to, and sourceURI is the
        /// ORIGINAL URI of said top-level resource.
        /// In the case of LEARN_STARTUP, targetURI should be the URI of a page
        /// that was loaded immediately after browser startup, and sourceURI should
        /// be null.
        /// @param loadContext - The nsILoadContext for the page load that we are
        /// learning about.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Learn([MarshalAs(UnmanagedType.Interface)] nsIURI targetURI, [MarshalAs(UnmanagedType.Interface)] nsIURI sourceURI, PredictorLearnReason reason, [MarshalAs(UnmanagedType.Interface)] nsILoadContext loadContext);
		
		/// <summary>
        /// Clear out all our learned knowledge
        ///
        /// This removes everything from our database so that any predictions begun
        /// after this completes will start from a blank slate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reset();
	}
	
	/// <summary>nsINetworkPredictorConsts </summary>
	public class nsINetworkPredictorConsts
	{
		
		// <summary>
        // Prediction reasons
        //
        // PREDICT_LINK - we are being asked to take predictive action because
        // the user is hovering over a link.
        //
        // PREDICT_LOAD - we are being asked to take predictive action because
        // the user has initiated a pageload.
        //
        // PREDICT_STARTUP - we are being asked to take predictive action
        // because the browser is starting up.
        // </summary>
		public const long PREDICT_LINK = 0;
		
		// 
		public const long PREDICT_LOAD = 1;
		
		// 
		public const long PREDICT_STARTUP = 2;
		
		// <summary>
        // Reasons we are learning something
        //
        // LEARN_LOAD_TOPLEVEL - we are learning about the toplevel resource of a
        // pageload (NOTE: this should ONLY be used by tests)
        //
        // LEARN_LOAD_SUBRESOURCE - we are learning a subresource from a pageload
        //
        // LEARN_LOAD_REDIRECT - we are learning about the re-direct of a URI
        //
        // LEARN_STARTUP - we are learning about a page loaded during startup
        // </summary>
		public const long LEARN_LOAD_TOPLEVEL = 0;
		
		// 
		public const long LEARN_LOAD_SUBRESOURCE = 1;
		
		// 
		public const long LEARN_LOAD_REDIRECT = 2;
		
		// 
		public const long LEARN_STARTUP = 3;
	}
}
