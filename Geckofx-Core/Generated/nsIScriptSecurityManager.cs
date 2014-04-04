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
// Generated by IDLImporter from file nsIScriptSecurityManager.idl
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
	[Guid("3b6e408b-e774-4612-89e8-3ef303564392")]
	public interface nsIScriptSecurityManager : nsIXPCSecurityManager
	{
		
		/// <summary>
        /// For each of these hooks returning NS_OK means 'let the action continue'.
        /// Returning an error code means 'veto the action'. XPConnect will return
        /// false to the js engine if the action is vetoed. The implementor of this
        /// interface is responsible for setting a JS exception into the JSContext
        /// if that is appropriate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CanCreateWrapper(System.IntPtr aJSContext, ref System.Guid aIID, [MarshalAs(UnmanagedType.Interface)] nsISupports aObj, [MarshalAs(UnmanagedType.Interface)] nsIClassInfo aClassInfo);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CanCreateInstance(System.IntPtr aJSContext, ref System.Guid aCID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CanGetService(System.IntPtr aJSContext, ref System.Guid aCID);
		
		/// <summary>
        /// Check that the script currently running in context "cx" can load "uri".
        ///
        /// Will return error code NS_ERROR_DOM_BAD_URI if the load request
        /// should be denied.
        ///
        /// @param cx the JSContext of the script causing the load
        /// @param uri the URI that is being loaded
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckLoadURIFromScript(System.IntPtr cx, [MarshalAs(UnmanagedType.Interface)] nsIURI uri);
		
		/// <summary>
        /// Check that content with principal aPrincipal can load "uri".
        ///
        /// Will return error code NS_ERROR_DOM_BAD_URI if the load request
        /// should be denied.
        ///
        /// @param aPrincipal the principal identifying the actor causing the load
        /// @param uri the URI that is being loaded
        /// @param flags the permission set, see above
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckLoadURIWithPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIURI uri, uint flags);
		
		/// <summary>
        /// Similar to checkLoadURIWithPrincipal but there are two differences:
        ///
        /// 1) The URI is a string, not a URI object.
        /// 2) This function assumes that the URI may still be subject to fixup (and
        /// hence will check whether fixed-up versions of the URI are allowed to
        /// load as well); if any of the versions of this URI is not allowed, this
        /// function will return error code NS_ERROR_DOM_BAD_URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckLoadURIStrWithPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase uri, uint flags);
		
		/// <summary>
        /// Return true if scripts may be executed in the scope of the given global.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ScriptAllowed(System.IntPtr aGlobal);
		
		/// <summary>
        /// Return the principal of the innermost frame of the currently
        /// executing script. Will return null if there is no script
        /// currently executing.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetSubjectPrincipal();
		
		/// <summary>
        /// Return the all-powerful system principal.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetSystemPrincipal();
		
		/// <summary>
        /// Return a principal that has the same origin as aURI.
        /// This principals should not be used for any data/permission check, it will
        /// have appId = UNKNOWN_APP_ID.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetSimpleCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Returns a principal that has the given information.
        /// @param appId is the app id of the principal. It can't be UNKNOWN_APP_ID.
        /// @param inMozBrowser is true if the principal has to be considered as
        /// inside a mozbrowser frame.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetAppCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri, uint appId, [MarshalAs(UnmanagedType.U1)] bool inMozBrowser);
		
		/// <summary>
        /// Returns a principal that has the appId and inMozBrowser of the docshell
        /// inside a mozbrowser frame.
        /// @param docShell to get appId/inMozBrowser from.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetDocShellCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIDocShell docShell);
		
		/// <summary>
        /// Returns a principal with that has the same origin as uri and is not part
        /// of an appliction.
        /// The returned principal will have appId = NO_APP_ID.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetNoAppCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri);
		
		/// <summary>
        /// Legacy name for getNoAppCodebasePrincipal.
        ///
        /// @deprecated use getNoAppCodebasePrincipal instead.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri);
		
		/// <summary>
        /// Return the principal of the specified object in the specified context.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetObjectPrincipal(Gecko.JsVal aObject, System.IntPtr jsContext);
		
		/// <summary>
        /// Returns true if the principal of the currently running script is the
        /// system principal, false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SubjectPrincipalIsSystem();
		
		/// <summary>
        /// Returns OK if aJSContext and target have the same "origin"
        /// (scheme, host, and port).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckSameOrigin(System.IntPtr aJSContext, [MarshalAs(UnmanagedType.Interface)] nsIURI aTargetURI);
		
		/// <summary>
        /// Returns OK if aSourceURI and target have the same "origin"
        /// (scheme, host, and port).
        /// ReportError flag suppresses error reports for functions that
        /// don't need reporting.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckSameOriginURI([MarshalAs(UnmanagedType.Interface)] nsIURI aSourceURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aTargetURI, [MarshalAs(UnmanagedType.U1)] bool reportError);
		
		/// <summary>
        /// Get the principal for the given channel.  This will typically be the
        /// channel owner if there is one, and the codebase principal for the
        /// channel's URI otherwise.  aChannel must not be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetChannelPrincipal([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
		
		/// <summary>
        /// Check whether a given principal is a system principal.  This allows us
        /// to avoid handing back the system principal to script while allowing
        /// script to check whether a given principal is system.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSystemPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
		
		/// <summary>
        /// Same as getSubjectPrincipal(), only faster. cx must *never* be
        /// passed null, and it must be the context on the top of the
        /// context stack. Does *not* reference count the returned
        /// principal.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetCxSubjectPrincipal(System.IntPtr cx);
		
		/// <summary>
        /// Returns the jar prefix for the app.
        /// appId can be NO_APP_ID or a valid app id. appId should not be
        /// UNKNOWN_APP_ID.
        /// inMozBrowser has to be true if the app is inside a mozbrowser iframe.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetJarPrefix(uint appId, [MarshalAs(UnmanagedType.U1)] bool inMozBrowser, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Per-domain controls to enable and disable script. This system is designed
        /// to be used by at most one consumer, and enforces this with its semantics.
        ///
        /// Initially, domainPolicyActive is false. When activateDomainPolicy() is
        /// invoked, domainPolicyActive becomes true, and subsequent calls to
        /// activateDomainPolicy() will fail until deactivate() is invoked on the
        /// nsIDomainPolicy returned from activateDomainPolicy(). At this point,
        /// domainPolicyActive becomes false again, and a new consumer may acquire
        /// control of the system by invoking activateDomainPolicy().
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDomainPolicy ActivateDomainPolicy();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDomainPolicyActiveAttribute();
		
		/// <summary>
        /// Query mechanism for the above policy.
        ///
        /// If domainPolicyEnabled is false, this simply returns the current value
        /// of javascript.enabled. Otherwise, it returns the same value, but taking
        /// the various blacklist/whitelist exceptions into account.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PolicyAllowsScript([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);
	}
	
	/// <summary>nsIScriptSecurityManagerConsts </summary>
	public class nsIScriptSecurityManagerConsts
	{
		
		// <summary>
        // Default permissions
        // </summary>
		public const ulong STANDARD = 0;
		
		// <summary>
        // nsIProtocolHandler::URI_FORBIDS_AUTOMATIC_DOCUMENT_REPLACEMENT flag set.
        // </summary>
		public const ulong LOAD_IS_AUTOMATIC_DOCUMENT_REPLACEMENT = 1<<0;
		
		// <summary>
        // probably means at least chrome: and resource:.
        // </summary>
		public const ulong ALLOW_CHROME = 1<<1;
		
		// <summary>
        // nsIProtocolHandler::URI_INHERITS_SECURITY_CONTEXT.
        // </summary>
		public const ulong DISALLOW_INHERIT_PRINCIPAL = 1<<2;
		
		// <summary>
        // JS-implemented extensions.
        // </summary>
		public const ulong DISALLOW_SCRIPT_OR_DATA = DISALLOW_INHERIT_PRINCIPAL;
		
		// <summary>
        // DISALLOW_INHERIT_PRINCIPAL
        // </summary>
		public const ulong DISALLOW_SCRIPT = 1<<3;
		
		// <summary>
        // a URI to not unnecessarily spam the error console.
        // </summary>
		public const ulong DONT_REPORT_ERRORS = 1<<4;
		
		// 
		public const ulong NO_APP_ID = 0;
		
		// 
		public const ulong UNKNOWN_APP_ID = 4294967295;
		
		// <summary>
        // UINT32_MAX
        // </summary>
		public const ulong SAFEBROWSING_APP_ID = 4294967294;
	}
}
