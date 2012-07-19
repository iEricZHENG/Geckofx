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
// Generated by IDLImporter from file nsIAccessibleEvent.idl
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
    /// An interface for accessibility events listened to
    /// by in-process accessibility clients, which can be used
    /// to find out how to get accessibility and DOM interfaces for
    /// the event and its target. To listen to in-process accessibility invents,
    /// make your object an nsIObserver, and listen for accessible-event by
    /// using code something like this:
    /// nsCOMPtr<nsIObserverService> observerService =
    /// do_GetService("@mozilla.org/observer-service;1", &rv);
    /// if (NS_SUCCEEDED(rv))
    /// rv = observerService->AddObserver(this, "accessible-event", PR_TRUE);
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7f66a33a-9ed7-4fd4-87a8-e431b0f43368")]
	public interface nsIAccessibleEvent
	{
		
		/// <summary>
        /// The type of event, based on the enumerated event values
        /// defined in this interface.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetEventTypeAttribute();
		
		/// <summary>
        /// The nsIAccessible associated with the event.
        /// May return null if no accessible is available
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetAccessibleAttribute();
		
		/// <summary>
        /// The nsIAccessibleDocument that the event target nsIAccessible
        /// resides in. This can be used to get the DOM window,
        /// the DOM document and the window handler, among other things.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleDocument GetAccessibleDocumentAttribute();
		
		/// <summary>
        /// The nsIDOMNode associated with the event
        /// May return null if accessible for event has been shut down
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetDOMNodeAttribute();
		
		/// <summary>
        /// Returns true if the event was caused by explicit user input,
        /// as opposed to purely originating from a timer or mouse movement
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsFromUserInputAttribute();
	}
	
	/// <summary>nsIAccessibleEventConsts </summary>
	public class nsIAccessibleEventConsts
	{
		
		// <summary>
        // An object has been created.
        // </summary>
		public const ulong EVENT_SHOW = 0x0001;
		
		// <summary>
        // An object has been destroyed.
        // </summary>
		public const ulong EVENT_HIDE = 0x0002;
		
		// <summary>
        // An object's children have changed
        // </summary>
		public const ulong EVENT_REORDER = 0x0003;
		
		// <summary>
        // The active descendant of a component has changed. The active descendant
        // is used in objects with transient children.
        // </summary>
		public const ulong EVENT_ACTIVE_DECENDENT_CHANGED = 0x0004;
		
		// <summary>
        // An object has received the keyboard focus.
        // </summary>
		public const ulong EVENT_FOCUS = 0x0005;
		
		// <summary>
        // An object's state has changed.
        // </summary>
		public const ulong EVENT_STATE_CHANGE = 0x0006;
		
		// <summary>
        // An object has changed location, shape, or size.
        // </summary>
		public const ulong EVENT_LOCATION_CHANGE = 0x0007;
		
		// <summary>
        // An object's Name property has changed.
        // </summary>
		public const ulong EVENT_NAME_CHANGE = 0x0008;
		
		// <summary>
        // An object's Description property has changed.
        // </summary>
		public const ulong EVENT_DESCRIPTION_CHANGE = 0x0009;
		
		// <summary>
        // An object's Value property has changed.
        // </summary>
		public const ulong EVENT_VALUE_CHANGE = 0x000A;
		
		// <summary>
        // An object's help has changed.
        // </summary>
		public const ulong EVENT_HELP_CHANGE = 0x000B;
		
		// <summary>
        // An object's default action has changed.
        // </summary>
		public const ulong EVENT_DEFACTION_CHANGE = 0x000C;
		
		// <summary>
        // An object's action has changed.
        // </summary>
		public const ulong EVENT_ACTION_CHANGE = 0x000D;
		
		// <summary>
        // An object's keyboard shortcut has changed.
        // </summary>
		public const ulong EVENT_ACCELERATOR_CHANGE = 0x000E;
		
		// <summary>
        // The selection within a container object has changed.
        // </summary>
		public const ulong EVENT_SELECTION = 0x000F;
		
		// <summary>
        // An item within a container object has been added to the selection.
        // </summary>
		public const ulong EVENT_SELECTION_ADD = 0x0010;
		
		// <summary>
        // An item within a container object has been removed from the selection.
        // </summary>
		public const ulong EVENT_SELECTION_REMOVE = 0x0011;
		
		// <summary>
        // Numerous selection changes have occurred within a container object.
        // </summary>
		public const ulong EVENT_SELECTION_WITHIN = 0x0012;
		
		// <summary>
        // An alert has been generated. Server applications send this event when a
        // user needs to know that a user interface element has changed.
        // </summary>
		public const ulong EVENT_ALERT = 0x0013;
		
		// <summary>
        // The foreground window has changed.
        // </summary>
		public const ulong EVENT_FOREGROUND = 0x0014;
		
		// <summary>
        // A menu item on the menu bar has been selected.
        // </summary>
		public const ulong EVENT_MENU_START = 0x0015;
		
		// <summary>
        // A menu from the menu bar has been closed.
        // </summary>
		public const ulong EVENT_MENU_END = 0x0016;
		
		// <summary>
        // A pop-up menu has been displayed.
        // </summary>
		public const ulong EVENT_MENUPOPUP_START = 0x0017;
		
		// <summary>
        // A pop-up menu has been closed.
        // </summary>
		public const ulong EVENT_MENUPOPUP_END = 0x0018;
		
		// <summary>
        // A window has received mouse capture.
        // </summary>
		public const ulong EVENT_CAPTURE_START = 0x0019;
		
		// <summary>
        // A window has lost mouse capture.
        // </summary>
		public const ulong EVENT_CAPTURE_END = 0x001A;
		
		// <summary>
        // A window is being moved or resized.
        // </summary>
		public const ulong EVENT_MOVESIZE_START = 0x001B;
		
		// <summary>
        // The movement or resizing of a window has finished
        // </summary>
		public const ulong EVENT_MOVESIZE_END = 0x001C;
		
		// <summary>
        // A window has entered context-sensitive Help mode
        // </summary>
		public const ulong EVENT_CONTEXTHELP_START = 0x001D;
		
		// <summary>
        // A window has exited context-sensitive Help mode
        // </summary>
		public const ulong EVENT_CONTEXTHELP_END = 0x001E;
		
		// <summary>
        // An application is about to enter drag-and-drop mode
        // </summary>
		public const ulong EVENT_DRAGDROP_START = 0x001F;
		
		// <summary>
        // An application is about to exit drag-and-drop mode
        // </summary>
		public const ulong EVENT_DRAGDROP_END = 0x0020;
		
		// <summary>
        // A dialog box has been displayed
        // </summary>
		public const ulong EVENT_DIALOG_START = 0x0021;
		
		// <summary>
        // A dialog box has been closed
        // </summary>
		public const ulong EVENT_DIALOG_END = 0x0022;
		
		// <summary>
        // Scrolling has started on a scroll bar
        // </summary>
		public const ulong EVENT_SCROLLING_START = 0x0023;
		
		// <summary>
        // Scrolling has ended on a scroll bar
        // </summary>
		public const ulong EVENT_SCROLLING_END = 0x0024;
		
		// <summary>
        // A window object is about to be minimized or maximized
        // </summary>
		public const ulong EVENT_MINIMIZE_START = 0x0025;
		
		// <summary>
        // A window object has been minimized or maximized
        // </summary>
		public const ulong EVENT_MINIMIZE_END = 0x0026;
		
		// <summary>
        // The loading of the document has completed.
        // </summary>
		public const ulong EVENT_DOCUMENT_LOAD_COMPLETE = 0x0027;
		
		// <summary>
        // The document contents are being reloaded.
        // </summary>
		public const ulong EVENT_DOCUMENT_RELOAD = 0x0028;
		
		// <summary>
        // The loading of the document was interrupted.
        // </summary>
		public const ulong EVENT_DOCUMENT_LOAD_STOPPED = 0x0029;
		
		// <summary>
        // The document wide attributes of the document object have changed.
        // </summary>
		public const ulong EVENT_DOCUMENT_ATTRIBUTES_CHANGED = 0x002A;
		
		// <summary>
        // The contents of the document have changed.
        // </summary>
		public const ulong EVENT_DOCUMENT_CONTENT_CHANGED = 0x002B;
		
		// 
		public const ulong EVENT_PROPERTY_CHANGED = 0x002C;
		
		// <summary>
        // A slide changed in a presentation document or a page boundary was
        // crossed in a word processing document.
        // </summary>
		public const ulong EVENT_PAGE_CHANGED = 0x002D;
		
		// <summary>
        // A text object's attributes changed.
        // Also see EVENT_OBJECT_ATTRIBUTE_CHANGED.
        // </summary>
		public const ulong EVENT_TEXT_ATTRIBUTE_CHANGED = 0x002E;
		
		// <summary>
        // The caret has moved to a new position.
        // </summary>
		public const ulong EVENT_TEXT_CARET_MOVED = 0x002F;
		
		// <summary>
        // This event indicates general text changes, i.e. changes to text that is
        // exposed through the IAccessibleText and IAccessibleEditableText interfaces.
        // </summary>
		public const ulong EVENT_TEXT_CHANGED = 0x0030;
		
		// <summary>
        // Text was inserted.
        // </summary>
		public const ulong EVENT_TEXT_INSERTED = 0x0031;
		
		// <summary>
        // Text was removed.
        // </summary>
		public const ulong EVENT_TEXT_REMOVED = 0x0032;
		
		// <summary>
        // Text was updated.
        // </summary>
		public const ulong EVENT_TEXT_UPDATED = 0x0033;
		
		// <summary>
        // The text selection changed.
        // </summary>
		public const ulong EVENT_TEXT_SELECTION_CHANGED = 0x0034;
		
		// <summary>
        // A visibile data event indicates the change of the visual appearance
        // of an accessible object.  This includes for example most of the
        // attributes available via the IAccessibleComponent interface.
        // </summary>
		public const ulong EVENT_VISIBLE_DATA_CHANGED = 0x0035;
		
		// <summary>
        // The caret moved from one column to the next.
        // </summary>
		public const ulong EVENT_TEXT_COLUMN_CHANGED = 0x0036;
		
		// <summary>
        // The caret moved from one section to the next.
        // </summary>
		public const ulong EVENT_SECTION_CHANGED = 0x0037;
		
		// <summary>
        // A table caption changed.
        // </summary>
		public const ulong EVENT_TABLE_CAPTION_CHANGED = 0x0038;
		
		// <summary>
        // A table's data changed.
        // </summary>
		public const ulong EVENT_TABLE_MODEL_CHANGED = 0x0039;
		
		// <summary>
        // A table's summary changed.
        // </summary>
		public const ulong EVENT_TABLE_SUMMARY_CHANGED = 0x003A;
		
		// <summary>
        // A table's row description changed.
        // </summary>
		public const ulong EVENT_TABLE_ROW_DESCRIPTION_CHANGED = 0x003B;
		
		// <summary>
        // A table's row header changed.
        // </summary>
		public const ulong EVENT_TABLE_ROW_HEADER_CHANGED = 0x003C;
		
		// 
		public const ulong EVENT_TABLE_ROW_INSERT = 0x003D;
		
		// 
		public const ulong EVENT_TABLE_ROW_DELETE = 0x003E;
		
		// 
		public const ulong EVENT_TABLE_ROW_REORDER = 0x003F;
		
		// <summary>
        // A table's column description changed.
        // </summary>
		public const ulong EVENT_TABLE_COLUMN_DESCRIPTION_CHANGED = 0x0040;
		
		// <summary>
        // A table's column header changed.
        // </summary>
		public const ulong EVENT_TABLE_COLUMN_HEADER_CHANGED = 0x0041;
		
		// 
		public const ulong EVENT_TABLE_COLUMN_INSERT = 0x0042;
		
		// 
		public const ulong EVENT_TABLE_COLUMN_DELETE = 0x0043;
		
		// 
		public const ulong EVENT_TABLE_COLUMN_REORDER = 0x0044;
		
		// 
		public const ulong EVENT_WINDOW_ACTIVATE = 0x0045;
		
		// 
		public const ulong EVENT_WINDOW_CREATE = 0x0046;
		
		// 
		public const ulong EVENT_WINDOW_DEACTIVATE = 0x0047;
		
		// 
		public const ulong EVENT_WINDOW_DESTROY = 0x0048;
		
		// 
		public const ulong EVENT_WINDOW_MAXIMIZE = 0x0049;
		
		// 
		public const ulong EVENT_WINDOW_MINIMIZE = 0x004A;
		
		// 
		public const ulong EVENT_WINDOW_RESIZE = 0x004B;
		
		// 
		public const ulong EVENT_WINDOW_RESTORE = 0x004C;
		
		// <summary>
        // The ending index of this link within the containing string has changed.
        // </summary>
		public const ulong EVENT_HYPERLINK_END_INDEX_CHANGED = 0x004D;
		
		// <summary>
        // The number of anchors assoicated with this hyperlink object has changed.
        // </summary>
		public const ulong EVENT_HYPERLINK_NUMBER_OF_ANCHORS_CHANGED = 0x004E;
		
		// <summary>
        // The hyperlink selected state changed from selected to unselected or
        // from unselected to selected.
        // </summary>
		public const ulong EVENT_HYPERLINK_SELECTED_LINK_CHANGED = 0x004F;
		
		// <summary>
        // One of the links associated with the hypertext object has been activated.
        // </summary>
		public const ulong EVENT_HYPERTEXT_LINK_ACTIVATED = 0x0050;
		
		// <summary>
        // One of the links associated with the hypertext object has been selected.
        // </summary>
		public const ulong EVENT_HYPERTEXT_LINK_SELECTED = 0x0051;
		
		// <summary>
        // The starting index of this link within the containing string has changed.
        // </summary>
		public const ulong EVENT_HYPERLINK_START_INDEX_CHANGED = 0x0052;
		
		// <summary>
        // Focus has changed from one hypertext object to another, or focus moved
        // from a non-hypertext object to a hypertext object, or focus moved from a
        // hypertext object to a non-hypertext object.
        // </summary>
		public const ulong EVENT_HYPERTEXT_CHANGED = 0x0053;
		
		// <summary>
        // The number of hyperlinks associated with a hypertext object changed.
        // </summary>
		public const ulong EVENT_HYPERTEXT_NLINKS_CHANGED = 0x0054;
		
		// <summary>
        // An object's attributes changed. Also see EVENT_TEXT_ATTRIBUTE_CHANGED.
        // </summary>
		public const ulong EVENT_OBJECT_ATTRIBUTE_CHANGED = 0x0055;
		
		// <summary>
        // A cursorable's virtual cursor has changed.
        // </summary>
		public const ulong EVENT_VIRTUALCURSOR_CHANGED = 0x0056;
		
		// <summary>
        // Help make sure event map does not get out-of-line.
        // </summary>
		public const ulong EVENT_LAST_ENTRY = 0x0057;
	}
	
	/// <summary>nsIAccessibleStateChangeEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9addd25d-8fa1-415e-94ec-6038f220d3e4")]
	public interface nsIAccessibleStateChangeEvent
	{
		
		/// <summary>
        /// Returns the state of accessible (see constants declared
        /// in nsIAccessibleStates).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetStateAttribute();
		
		/// <summary>
        /// Returns true if the state is extra state.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsExtraState();
		
		/// <summary>
        /// Returns true if the state is turned on.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsEnabled();
	}
	
	/// <summary>nsIAccessibleTextChangeEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("21e0f8bd-5638-4964-870b-3c8e944ac4c4")]
	public interface nsIAccessibleTextChangeEvent
	{
		
		/// <summary>
        /// Returns offset of changed text in accessible.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStartAttribute();
		
		/// <summary>
        /// Returns length of changed text.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLengthAttribute();
		
		/// <summary>
        /// Returns true if text was inserted, otherwise false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsInserted();
		
		/// <summary>
        /// The inserted or removed text
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetModifiedTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aModifiedText);
	}
	
	/// <summary>nsIAccessibleHideEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a2bd2eca-3afa-489b-afb2-f93ef32ad99c")]
	public interface nsIAccessibleHideEvent
	{
		
		/// <summary>
        /// Return an accessible that was a parent of the target.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetTargetParentAttribute();
		
		/// <summary>
        /// Return an accessible that was a next sibling of the target
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetTargetNextSiblingAttribute();
		
		/// <summary>
        /// Return an accessible that was a parent of the target
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetTargetPrevSiblingAttribute();
	}
	
	/// <summary>nsIAccessibleCaretMoveEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5675c486-a230-4d85-a4bd-33670826d5ff")]
	public interface nsIAccessibleCaretMoveEvent
	{
		
		/// <summary>
        /// Return caret offset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCaretOffsetAttribute();
	}
	
	/// <summary>nsIAccessibleTableChangeEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("df517997-ed52-4ea2-b310-2f8e0fe64572")]
	public interface nsIAccessibleTableChangeEvent
	{
		
		/// <summary>
        /// Return the row or column index.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRowOrColIndexAttribute();
		
		/// <summary>
        /// Return the number of rows or cols
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumRowsOrColsAttribute();
	}
	
	/// <summary>
    /// An interface for virtual cursor changed events.
    /// Passes previous cursor position and text offsets.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("370e8b9b-2bbc-4bff-a9c7-16ddc54aea21")]
	public interface nsIAccessibleVirtualCursorChangeEvent
	{
		
		/// <summary>
        /// Previous object pointed at by virtual cursor. null if none.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetOldAccessibleAttribute();
		
		/// <summary>
        /// Previous start offset of pivot. -1 if none.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOldStartOffsetAttribute();
		
		/// <summary>
        /// Previous end offset of pivot. -1 if none.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOldEndOffsetAttribute();
	}
}
