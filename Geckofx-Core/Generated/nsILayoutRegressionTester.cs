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
// Generated by IDLImporter from file nsILayoutRegressionTester.idl
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
	[Guid("B249B2C0-EE11-11DA-8AD9-0800200C9A66")]
	public interface nsILayoutRegressionTester
	{
		
		/// <summary>
        /// an error occurred
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int DumpFrameModel([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindowToDump, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile, uint aFlagsMask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CompareFrameModels([MarshalAs(UnmanagedType.Interface)] nsIFile aBaseFile, [MarshalAs(UnmanagedType.Interface)] nsIFile aVerFile, uint aFlags);
	}
	
	/// <summary>nsILayoutRegressionTesterConsts </summary>
	public class nsILayoutRegressionTesterConsts
	{
		
		// <summary>
        // Dumps the content of a window
        // @param aWindowToDump       the window to dump (may be an iframe etc)
        // @param aFile               the file to dump to. It will be created if necessary, otherwise
        //                                truncated. If nil, write to stdout.
        // @param aFlagsMask          some flags that determine what to dump
        // @param aFlagsMask          some flags that determine what to dump
        // @param aResult             a status value indicating whether the dump happened,
        //                                whether the page was still loading, or whether some other error happened.
        // </summary>
		public const int DUMP_FLAGS_MASK_DEFAULT = 0;
		
		// 
		public const int DUMP_FLAGS_MASK_PRINT_MODE = 1;
		
		// 
		public const long DUMP_RESULT_COMPLETED = 0;
		
		// <summary>
        // loaded OK
        // </summary>
		public const long DUMP_RESULT_LOADING = 1;
		
		// <summary>
        // still loading
        // </summary>
		public const long DUMP_RESULT_ERROR = 2;
		
		// <summary>
        // Compares the contents of frame model files
        // @param aBaseFile           the baseline file, opened with read permissions
        // @param aVerFile            file containing the results to verify, opened with read permissions
        // @param aFlags              flags specifying output verbosity
        // @param aResult             result of the comparison: zero if the files are same, non-zero if different
        // </summary>
		public const int COMPARE_FLAGS_VERBOSE = 0;
		
		// 
		public const int COMPARE_FLAGS_BRIEF = 1;
	}
}
