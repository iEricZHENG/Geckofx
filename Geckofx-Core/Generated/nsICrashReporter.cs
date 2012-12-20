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
// Generated by IDLImporter from file nsICrashReporter.idl
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
    /// Provides access to crash reporting functionality.
    ///
    /// @status UNSTABLE - This interface is not frozen and will probably change in
    /// future releases.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56761088-57ad-4f5c-bd61-f678c2807fe0")]
	public interface nsICrashReporter
	{
		
		/// <summary>
        /// Enable or disable the crashreporter at runtime.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEnabledAttribute();
		
		/// <summary>
        /// Enable or disable the crashreporter at runtime.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aEnabled);
		
		/// <summary>
        /// Get or set the URL to which crash reports will be submitted.
        /// Only https and http URLs are allowed, as the submission is handled
        /// by OS-native networking libraries.
        ///
        /// @throw NS_ERROR_NOT_INITIALIZED if crash reporting is not initialized
        /// @throw NS_ERROR_INVALID_ARG on set if a non-http(s) URL is assigned
        /// @throw NS_ERROR_FAILURE on get if no URL is set
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURL GetServerURLAttribute();
		
		/// <summary>
        /// Get or set the URL to which crash reports will be submitted.
        /// Only https and http URLs are allowed, as the submission is handled
        /// by OS-native networking libraries.
        ///
        /// @throw NS_ERROR_NOT_INITIALIZED if crash reporting is not initialized
        /// @throw NS_ERROR_INVALID_ARG on set if a non-http(s) URL is assigned
        /// @throw NS_ERROR_FAILURE on get if no URL is set
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetServerURLAttribute([MarshalAs(UnmanagedType.Interface)] nsIURL aServerURL);
		
		/// <summary>
        /// Get or set the path on the local system to which minidumps will be
        /// written when a crash happens.
        ///
        /// @throw NS_ERROR_NOT_INITIALIZED if crash reporting is not initialized
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetMinidumpPathAttribute();
		
		/// <summary>
        /// Get or set the path on the local system to which minidumps will be
        /// written when a crash happens.
        ///
        /// @throw NS_ERROR_NOT_INITIALIZED if crash reporting is not initialized
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMinidumpPathAttribute([MarshalAs(UnmanagedType.Interface)] nsIFile aMinidumpPath);
		
		/// <summary>
        /// Add some extra data to be submitted with a crash report.
        ///
        /// @param key
        /// Name of the data to be added.
        /// @param data
        /// Data to be added.
        ///
        /// @throw NS_ERROR_NOT_INITIALIZED if crash reporting not initialized
        /// @throw NS_ERROR_INVALID_ARG if key or data contain invalid characters.
        /// Invalid characters for key are '=' and
        /// '\n'.  Invalid character for data is '\0'.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AnnotateCrashReport([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data);
		
		/// <summary>
        /// Append some data to the "Notes" field, to be submitted with a crash report.
        /// Unlike annotateCrashReport, this method will append to existing data.
        ///
        /// @param data
        /// Data to be added.
        ///
        /// @throw NS_ERROR_NOT_INITIALIZED if crash reporting not initialized
        /// @throw NS_ERROR_INVALID_ARG if data contains invalid characters.
        /// The only invalid character is '\0'.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendAppNotesToCrashReport([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data);
		
		/// <summary>
        /// Register a given memory range to be included in the crash report.
        ///
        /// @param ptr
        /// The starting address for the bytes.
        /// @param size
        /// The number of bytes to include.
        ///
        /// @throw NS_ERROR_NOT_INITIALIZED if crash reporting not initialized
        /// @throw NS_ERROR_NOT_IMPLEMENTED if unavailable on the current OS
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterAppMemory(ulong ptr, ulong size);
		
		/// <summary>
        /// Write a minidump immediately, with the user-supplied exception
        /// information. This is implemented on Windows only, because
        /// SEH (structured exception handling) exists on Windows only.
        ///
        /// @param aExceptionInfo  EXCEPTION_INFO* provided by Window's SEH
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WriteMinidumpForException(System.IntPtr aExceptionInfo);
		
		/// <summary>
        /// Append note containing an Obj-C exception's info.
        ///
        /// @param aException  NSException object to append note for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendObjCExceptionInfoToAppNotes(System.IntPtr aException);
		
		/// <summary>
        /// User preference for submitting crash reports.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSubmitReportsAttribute();
		
		/// <summary>
        /// User preference for submitting crash reports.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSubmitReportsAttribute([MarshalAs(UnmanagedType.U1)] bool aSubmitReports);
	}
}
