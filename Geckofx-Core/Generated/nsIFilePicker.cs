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
// Generated by IDLImporter from file nsIFilePicker.idl
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
	[Guid("0d79adad-b244-49A5-9997-2a8cad93fc44")]
	public interface nsIFilePickerShownCallback
	{
		
		/// <summary>
        /// Callback which is called when a filepicker is shown and a result
        /// is returned.
        ///
        /// @param aResult One of returnOK, returnCancel, or returnReplace
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Done(short aResult);
	}
	
	/// <summary>nsIFilePicker </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9840d564-42c8-4d78-9a4d-71002343c918")]
	public interface nsIFilePicker
	{
		
		/// <summary>
        /// Initialize the file picker widget.  The file picker is not valid until this
        /// method is called.
        ///
        /// @param      parent   nsIDOMWindow parent.  This dialog will be dependent
        /// on this parent. parent must be non-null.
        /// @param      title    The title for the file widget
        /// @param      mode     load, save, or get folder
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, short mode);
		
		/// <summary>
        /// Append to the  filter list with things from the predefined list
        ///
        /// @param      filters  mask of filters i.e. (filterAll | filterHTML)
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendFilters(int filterMask);
		
		/// <summary>
        /// Add a filter
        ///
        /// @param      title    name of the filter
        /// @param      filter   extensions to filter -- semicolon and space separated
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendFilter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase filter);
		
		/// <summary>
        /// The filename that should be suggested to the user as a default. This should
        /// include the extension.
        ///
        /// @throws NS_ERROR_FAILURE on attempts to get
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultString);
		
		/// <summary>
        /// The filename that should be suggested to the user as a default. This should
        /// include the extension.
        ///
        /// @throws NS_ERROR_FAILURE on attempts to get
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultString);
		
		/// <summary>
        /// The extension that should be associated with files of the type we
        /// want to work with.  On some platforms, this extension will be
        /// automatically appended to filenames the user enters, if needed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultExtensionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultExtension);
		
		/// <summary>
        /// The extension that should be associated with files of the type we
        /// want to work with.  On some platforms, this extension will be
        /// automatically appended to filenames the user enters, if needed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultExtensionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultExtension);
		
		/// <summary>
        /// The filter which is currently selected in the File Picker dialog
        ///
        /// @return Returns the index (0 based) of the selected filter in the filter list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFilterIndexAttribute();
		
		/// <summary>
        /// The filter which is currently selected in the File Picker dialog
        ///
        /// @return Returns the index (0 based) of the selected filter in the filter list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilterIndexAttribute(int aFilterIndex);
		
		/// <summary>
        /// Set the directory that the file open/save dialog initially displays
        ///
        /// @param      displayDirectory  the name of the directory
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetDisplayDirectoryAttribute();
		
		/// <summary>
        /// Set the directory that the file open/save dialog initially displays
        ///
        /// @param      displayDirectory  the name of the directory
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayDirectoryAttribute([MarshalAs(UnmanagedType.Interface)] nsIFile aDisplayDirectory);
		
		/// <summary>
        /// Get the nsIFile for the file or directory.
        ///
        /// @return Returns the file currently selected
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetFileAttribute();
		
		/// <summary>
        /// Get the nsIURI for the file or directory.
        ///
        /// @return Returns the file currently selected
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetFileURLAttribute();
		
		/// <summary>
        /// Get the enumerator for the selected files
        /// only works in the modeOpenMultiple mode
        ///
        /// @return Returns the files currently selected
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetFilesAttribute();
		
		/// <summary>
        /// Get the DOM File for the file.
        ///
        /// @return Returns the file currently selected as File
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetDomfileAttribute();
		
		/// <summary>
        /// Get the enumerator for the selected files
        /// only works in the modeOpenMultiple mode
        ///
        /// @return Returns the files currently selected as Files
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetDomfilesAttribute();
		
		/// <summary>
        /// Controls whether the chosen file(s) should be added to the system's recent
        /// documents list. This attribute will be ignored if the system has no "Recent
        /// Docs" concept, or if the application is in private browsing mode (in which
        /// case the file will not be added). Defaults to true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAddToRecentDocsAttribute();
		
		/// <summary>
        /// Controls whether the chosen file(s) should be added to the system's recent
        /// documents list. This attribute will be ignored if the system has no "Recent
        /// Docs" concept, or if the application is in private browsing mode (in which
        /// case the file will not be added). Defaults to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAddToRecentDocsAttribute([MarshalAs(UnmanagedType.U1)] bool aAddToRecentDocs);
		
		/// <summary>
        /// Show File Dialog. The dialog is displayed modally.
        ///
        /// @return returnOK if the user selects OK, returnCancel if the user selects cancel
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short Show();
		
		/// <summary>
        /// Opens the file dialog asynchrounously.
        /// The passed in object's done method will be called upon completion.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open([MarshalAs(UnmanagedType.Interface)] nsIFilePickerShownCallback aFilePickerShownCallback);
		
		/// <summary>
        /// The picker's mode, as set by the 'mode' argument passed to init()
        /// (one of the modeOpen et. al. constants specified above).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetModeAttribute();
	}
	
	/// <summary>nsIFilePickerConsts </summary>
	public class nsIFilePickerConsts
	{
		
		// 
		public const short modeOpen = 0;
		
		// <summary>
        // Load a file or directory
        // </summary>
		public const short modeSave = 1;
		
		// <summary>
        // Save a file or directory
        // </summary>
		public const short modeGetFolder = 2;
		
		// <summary>
        // Select a folder/directory
        // </summary>
		public const short modeOpenMultiple = 3;
		
		// <summary>
        // Load multiple files
        // </summary>
		public const short returnOK = 0;
		
		// <summary>
        // User hit Ok, process selection
        // </summary>
		public const short returnCancel = 1;
		
		// <summary>
        // User hit cancel, ignore selection
        // </summary>
		public const short returnReplace = 2;
		
		// <summary>
        // User acknowledged file already exists so ok to replace, process selection
        // </summary>
		public const long filterAll = 0x001;
		
		// <summary>
        // .*
        // </summary>
		public const long filterHTML = 0x002;
		
		// <summary>
        // .html; *.htm
        // </summary>
		public const long filterText = 0x004;
		
		// <summary>
        // .txt
        // </summary>
		public const long filterImages = 0x008;
		
		// <summary>
        // .psd; *.raw
        // </summary>
		public const long filterXML = 0x010;
		
		// <summary>
        // .xml
        // </summary>
		public const long filterXUL = 0x020;
		
		// <summary>
        // .xul
        // </summary>
		public const long filterApps = 0x040;
		
		// <summary>
        // Applications (per-platform implementation)
        // </summary>
		public const long filterAllowURLs = 0x080;
		
		// <summary>
        // Allow URLs
        // </summary>
		public const long filterAudio = 0x100;
		
		// <summary>
        // .wav; *.wma
        // </summary>
		public const long filterVideo = 0x200;
	}
}
