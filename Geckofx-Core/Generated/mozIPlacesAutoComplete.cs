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
// Generated by IDLImporter from file mozIPlacesAutoComplete.idl
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
    /// This interface provides some constants used by the Places AutoComplete
    /// search provider as well as methods to track opened pages for AutoComplete
    /// purposes.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("61b6348a-09e1-4810-8057-f8cb3cec6ef8")]
	public interface mozIPlacesAutoComplete
	{
		
		/// <summary>
        /// Mark a page as being currently open.
        ///
        /// @note Pages will not be automatically unregistered when Private Browsing
        /// mode is entered or exited.  Therefore, consumers MUST unregister or
        /// register themselves.
        ///
        /// @param aURI
        /// The URI to register as an open page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterOpenPage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Mark a page as no longer being open (either by closing the window or tab,
        /// or by navigating away from that page).
        ///
        /// @note Pages will not be automatically unregistered when Private Browsing
        /// mode is entered or exited.  Therefore, consumers MUST unregister or
        /// register themselves.
        ///
        /// @param aURI
        /// The URI to unregister as an open page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterOpenPage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
	}
	
	/// <summary>mozIPlacesAutoCompleteConsts </summary>
	public class mozIPlacesAutoCompleteConsts
	{
		
		// <summary>
        // Match anywhere in each searchable term.
        // </summary>
		public const long MATCH_ANYWHERE = 0;
		
		// <summary>
        // Match first on word boundaries, and if we do not get enough results, then
        // match anywhere in each searchable term.
        // </summary>
		public const long MATCH_BOUNDARY_ANYWHERE = 1;
		
		// <summary>
        // Match on word boundaries in each searchable term.
        // </summary>
		public const long MATCH_BOUNDARY = 2;
		
		// <summary>
        // Match only the beginning of each search term.
        // </summary>
		public const long MATCH_BEGINNING = 3;
		
		// <summary>
        // Match anywhere in each searchable term without doing any transformation
        // or stripping on the underlying data.
        // </summary>
		public const long MATCH_ANYWHERE_UNMODIFIED = 4;
		
		// <summary>
        // Match only the beginning of each search term using a case sensitive
        // comparator.
        // </summary>
		public const long MATCH_BEGINNING_CASE_SENSITIVE = 5;
		
		// <summary>
        // Search through history.
        // </summary>
		public const long BEHAVIOR_HISTORY = 1<<0;
		
		// <summary>
        // Search though bookmarks.
        // </summary>
		public const long BEHAVIOR_BOOKMARK = 1<<1;
		
		// <summary>
        // Search through tags.
        // </summary>
		public const long BEHAVIOR_TAG = 1<<2;
		
		// <summary>
        // Search the title of pages.
        // </summary>
		public const long BEHAVIOR_TITLE = 1<<3;
		
		// <summary>
        // Search the URL of pages.
        // </summary>
		public const long BEHAVIOR_URL = 1<<4;
		
		// <summary>
        // Search for typed pages.
        // </summary>
		public const long BEHAVIOR_TYPED = 1<<5;
		
		// <summary>
        // Search javascript: URLs.
        // </summary>
		public const long BEHAVIOR_JAVASCRIPT = 1<<6;
		
		// <summary>
        // Search for pages that have been marked as being opened, such as a tab
        // in a tabbrowser.
        // </summary>
		public const long BEHAVIOR_OPENPAGE = 1<<7;
		
		// <summary>
        // Use intersection between history, typed, bookmark, tag and openpage
        // instead of union, when the restrict bit is set.
        // </summary>
		public const long BEHAVIOR_RESTRICT = 1<<8;
		
		// <summary>
        // Include search suggestions from the currently selected search provider.
        // </summary>
		public const long BEHAVIOR_SEARCHES = 1<<9;
	}
}
