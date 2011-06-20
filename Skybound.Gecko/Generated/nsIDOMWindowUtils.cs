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
// Generated by IDLImporter from file nsIDOMWindowUtils.idl
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
    /// nsIDOMWindowUtils is intended for infrequently-used methods related
    /// to the current nsIDOMWindow.  Some of the methods may require
    /// elevated privileges; the method implementations should contain the
    /// necessary security checks.  Access this interface by calling
    /// getInterface on a DOMWindow.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3828e648-af61-47e1-b9bc-89ca51bc19f2")]
	public interface nsIDOMWindowUtils
	{
		
		/// <summary>
        /// Image animation mode of the window. When this attribute's value
        /// is changed, the implementation should set all images in the window
        /// to the given value. That is, when set to kDontAnimMode, all images
        /// will stop animating. The attribute's value must be one of the
        /// animationMode values from imgIContainer.
        /// @note Images may individually override the window's setting after
        /// the window's mode is set. Therefore images given different modes
        /// since the last setting of the window's mode may behave
        /// out of line with the window's overall mode.
        /// @note The attribute's value is the window's overall mode. It may
        /// for example continue to report kDontAnimMode after all images
        /// have subsequently been individually animated.
        /// @note Only images immediately in this window are affected;
        /// this is not recursive to subwindows.
        /// @see imgIContainer
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetImageAnimationModeAttribute();
		
		/// <summary>
        /// Image animation mode of the window. When this attribute's value
        /// is changed, the implementation should set all images in the window
        /// to the given value. That is, when set to kDontAnimMode, all images
        /// will stop animating. The attribute's value must be one of the
        /// animationMode values from imgIContainer.
        /// @note Images may individually override the window's setting after
        /// the window's mode is set. Therefore images given different modes
        /// since the last setting of the window's mode may behave
        /// out of line with the window's overall mode.
        /// @note The attribute's value is the window's overall mode. It may
        /// for example continue to report kDontAnimMode after all images
        /// have subsequently been individually animated.
        /// @note Only images immediately in this window are affected;
        /// this is not recursive to subwindows.
        /// @see imgIContainer
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetImageAnimationModeAttribute(ushort aImageAnimationMode);
		
		/// <summary>
        /// Whether the charset of the window's current document has been forced by
        /// the user.
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDocCharsetIsForcedAttribute();
		
		/// <summary>
        /// Get current cursor type from this window
        /// @return the current value of nsCursor
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetCursorType();
		
		/// <summary>
        /// Function to get metadata associated with the window's current document
        /// @param aName the name of the metadata.  This should be all lowercase.
        /// @return the value of the metadata, or the empty string if it's not set
        ///
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDocumentMetadata([MarshalAs(UnmanagedType.LPStruct)] nsAString aName, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Force an immediate redraw of this window.  The parameter specifies
        /// the number of times to redraw, and the return value is the length,
        /// in milliseconds, that the redraws took.  If aCount is not specified
        /// or is 0, it is taken to be 1.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Redraw(uint aCount);
		
		/// <summary>
        /// Set the CSS viewport to be |widthPx| x |heightPx| in units of CSS
        /// pixels, regardless of the size of the enclosing widget/view.
        /// This will trigger reflow.
        ///
        /// The caller of this method must have UniversalXPConnect
        /// privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCSSViewport(double aWidthPx, double aHeightPx);
		
		/// <summary>
        /// For any scrollable element, this allows you to override the
        /// visible region and draw more than what is visible, which is
        /// useful for asynchronous drawing. The "displayport" will be
        /// <xPx, yPx, widthPx, heightPx> in units of CSS pixels,
        /// regardless of the size of the enclosing container.  This
        /// will *not* trigger reflow.
        ///
        /// For the root scroll area, pass in the root document element.
        /// For scrollable elements, pass in the container element (for
        /// instance, the element with overflow: scroll).
        ///
        /// <x, y> is relative to the top-left of what would normally be
        /// the visible area of the element. This means that the pixels
        /// rendered to the displayport take scrolling into account,
        /// for example.
        ///
        /// It's legal to set a displayport that extends beyond the overflow
        /// area in any direction (left/right/top/bottom).
        ///
        /// It's also legal to set a displayport that extends beyond the
        /// area's bounds.  No pixels are rendered outside the area bounds.
        ///
        /// The caller of this method must have UniversalXPConnect
        /// privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayPortForElement(double aXPx, double aYPx, double aWidthPx, double aHeightPx, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// Get/set the resolution at which rescalable web content is drawn.
        /// Currently this is only (some) thebes content.
        ///
        /// Setting a new resolution does *not* trigger reflow.  This API is
        /// entirely separate from textZoom and fullZoom; a resolution scale
        /// can be applied together with both textZoom and fullZoom.
        ///
        /// The effect of is API for gfx code to allocate more or fewer
        /// pixels for rescalable content by a factor of |resolution| in
        /// either or both dimensions.  setResolution() together with
        /// setDisplayport() can be used to implement a non-reflowing
        /// scale-zoom in concert with another entity that can draw with a
        /// scale.  For example, to scale a content |window| inside a
        /// <browser> by a factor of 2.0
        ///
        /// window.setDisplayport(x, y, oldW / 2.0, oldH / 2.0);
        /// window.setResolution(2.0, 2.0);
        /// // elsewhere
        /// browser.setViewportScale(2.0, 2.0);
        ///
        /// The caller of this method must have UniversalXPConnect
        /// privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetResolution(double aXResolution, double aYResolution);
		
		/// <summary>
        ///Synthesize a mouse event. The event types supported are:
        /// mousedown, mouseup, mousemove, mouseover, mouseout, contextmenu
        ///
        /// Events are sent in coordinates offset by aX and aY from the window.
        ///
        /// Note that additional events may be fired as a result of this call. For
        /// instance, typically a click event will be fired as a result of a
        /// mousedown and mouseup in sequence.
        ///
        /// Normally at this level of events, the mouseover and mouseout events are
        /// only fired when the window is entered or exited. For inter-element
        /// mouseover and mouseout events, a movemove event fired on the new element
        /// should be sufficient to generate the correct over and out events as well.
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        ///
        /// The event is dispatched via the toplevel window, so it could go to any
        /// window under the toplevel window, in some cases it could never reach this
        /// window at all.
        ///
        /// @param aType event type
        /// @param aX x offset in CSS pixels
        /// @param aY y offset in CSS pixels
        /// @param aButton button to synthesize
        /// @param aClickCount number of clicks that have been performed
        /// @param aModifiers modifiers pressed, using constants defined in nsIDOMNSEvent
        /// @param aIgnoreRootScrollFrame whether the event should ignore viewport bounds
        /// during dispatch
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendMouseEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, double aX, double aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.Bool)] bool aIgnoreRootScrollFrame);
		
		/// <summary>
        ///The same as sendMouseEvent but ensures that the event is dispatched to
        /// this DOM window or one of its children.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendMouseEventToWindow([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, double aX, double aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.Bool)] bool aIgnoreRootScrollFrame);
		
		/// <summary>
        ///Synthesize a mouse scroll event for a window. The event types supported
        /// are:
        /// DOMMouseScroll
        /// MozMousePixelScroll
        ///
        /// Events are sent in coordinates offset by aX and aY from the window.
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        ///
        /// @param aType event type
        /// @param aX x offset in CSS pixels
        /// @param aY y offset in CSS pixels
        /// @param aButton button to synthesize
        /// @param aScrollFlags flag bits --- see nsMouseScrollFlags in nsGUIEvent.h
        /// @param aDelta the direction and amount to scroll (in lines or pixels,
        /// depending on the event type)
        /// @param aModifiers modifiers pressed, using constants defined in nsIDOMNSEvent
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendMouseScrollEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, double aX, double aY, int aButton, int aScrollFlags, int aDelta, int aModifiers);
		
		/// <summary>
        /// Synthesize a key event to the window. The event types supported are:
        /// keydown, keyup, keypress
        ///
        /// Key events generally end up being sent to the focused node.
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        ///
        /// @param aType event type
        /// @param aKeyCode key code
        /// @param aCharCode character code
        /// @param aModifiers modifiers pressed, using constants defined in nsIDOMNSEvent
        /// @param aPreventDefault if true, preventDefault() the event before dispatch
        ///
        /// @return false if the event had preventDefault() called on it,
        /// true otherwise.  In other words, true if and only if the
        /// default action was taken.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SendKeyEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, int aKeyCode, int aCharCode, int aModifiers, [MarshalAs(UnmanagedType.Bool)] bool aPreventDefault);
		
		/// <summary>
        /// See nsIWidget::SynthesizeNativeKeyEvent
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendNativeKeyEvent(int aNativeKeyboardLayout, int aNativeKeyCode, int aModifierFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAString aCharacters, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUnmodifiedCharacters);
		
		/// <summary>
        /// See nsIWidget::SynthesizeNativeMouseEvent
        ///
        /// Will be called on the widget that contains aElement.
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendNativeMouseEvent(int aScreenX, int aScreenY, int aNativeMessage, int aModifierFlags, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// See nsIWidget::ActivateNativeMenuItemAt
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActivateNativeMenuItemAt([MarshalAs(UnmanagedType.LPStruct)] nsAString indexString);
		
		/// <summary>
        /// See nsIWidget::ForceUpdateNativeMenuAt
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceUpdateNativeMenuAt([MarshalAs(UnmanagedType.LPStruct)] nsAString indexString);
		
		/// <summary>
        /// Focus the element aElement. The element should be in the same document
        /// that the window is displaying. Pass null to blur the element, if any,
        /// that currently has focus, and focus the document.
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        ///
        /// @param aElement the element to focus
        ///
        /// Do not use this method. Just use element.focus if available or
        /// nsIFocusManager::SetFocus instead.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Focus([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// Force a garbage collection followed by a cycle collection.
        ///
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges in non-debug builds. Available to all callers in debug builds.
        ///
        /// @param aListener listener that receives information about the CC graph
        /// (see @mozilla.org/cycle-collector-logger;1 for a logger
        /// component)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GarbageCollect([MarshalAs(UnmanagedType.Interface)] nsICycleCollectorListener aListener);
		
		/// <summary>
        /// Force processing of any queued paints
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ProcessUpdates();
		
		/// <summary>
        ///Synthesize a simple gesture event for a window. The event types
        /// supported are: MozSwipeGesture, MozMagnifyGestureStart,
        /// MozMagnifyGestureUpdate, MozMagnifyGesture, MozRotateGestureStart,
        /// MozRotateGestureUpdate, MozRotateGesture, MozPressTapGesture, and
        /// MozTapGesture.
        ///
        /// Cannot be accessed from unprivileged context (not
        /// content-accessible) Will throw a DOM security error if called
        /// without UniversalXPConnect privileges.
        ///
        /// @param aType event type
        /// @param aX x offset in CSS pixels
        /// @param aY y offset in CSS pixels
        /// @param aDirection direction, using constants defined in nsIDOMSimpleGestureEvent
        /// @param aDelta  amount of magnification or rotation for magnify and rotation events
        /// @param aModifiers modifiers pressed, using constants defined in nsIDOMNSEvent
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendSimpleGestureEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, double aX, double aY, uint aDirection, double aDelta, int aModifiers);
		
		/// <summary>
        /// Retrieve the element at point aX, aY in the window's document.
        ///
        /// @param aIgnoreRootScrollFrame whether or not to ignore the root scroll
        /// frame when retrieving the element. If false, this method returns
        /// null for coordinates outside of the viewport.
        /// @param aFlushLayout flushes layout if true. Otherwise, no flush occurs.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement ElementFromPoint(double aX, double aY, [MarshalAs(UnmanagedType.Bool)] bool aIgnoreRootScrollFrame, [MarshalAs(UnmanagedType.Bool)] bool aFlushLayout);
		
		/// <summary>
        /// Retrieve all nodes that intersect a rect in the window's document.
        ///
        /// @param aX x reference for the rectangle in CSS pixels
        /// @param aY y reference for the rectangle in CSS pixels
        /// @param aTopSize How much to expand up the rectangle
        /// @param aRightSize How much to expand right the rectangle
        /// @param aBottomSize How much to expand down the rectangle
        /// @param aLeftSize How much to expand left the rectangle
        /// @param aIgnoreRootScrollFrame whether or not to ignore the root scroll
        /// frame when retrieving the element. If false, this method returns
        /// null for coordinates outside of the viewport.
        /// @param aFlushLayout flushes layout if true. Otherwise, no flush occurs.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList NodesFromRect(double aX, double aY, double aTopSize, double aRightSize, double aBottomSize, double aLeftSize, [MarshalAs(UnmanagedType.Bool)] bool aIgnoreRootScrollFrame, [MarshalAs(UnmanagedType.Bool)] bool aFlushLayout);
		
		/// <summary>
        /// Compare the two canvases, returning the number of differing pixels and
        /// the maximum difference in a channel.  This will throw an error if
        /// the dimensions of the two canvases are different.
        ///
        /// This method requires UniversalXPConnect privileges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint CompareCanvases([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLCanvasElement aCanvas1, [MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLCanvasElement aCanvas2, out uint aMaxDifference);
		
		/// <summary>
        /// Returns true if a MozAfterPaint event has been queued but not yet
        /// fired.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsMozAfterPaintPendingAttribute();
		
		/// <summary>
        /// Suppresses/unsuppresses user initiated event handling in window's document
        /// and subdocuments.
        ///
        /// @throw NS_ERROR_DOM_SECURITY_ERR if called without UniversalXPConnect
        /// privileges and NS_ERROR_FAILURE if window doesn't have a document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SuppressEventHandling([MarshalAs(UnmanagedType.Bool)] bool aSuppress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearMozAfterPaintEvents();
		
		/// <summary>
        /// Disable or enable non synthetic test mouse events on *all* windows.
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible).
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        ///
        /// @param aDisable  If true, disable all non synthetic test mouse events
        /// on all windows.  Otherwise, enable them.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableNonTestMouseEvents([MarshalAs(UnmanagedType.Bool)] bool aDisable);
		
		/// <summary>
        /// Returns the scroll position of the window's currently loaded document.
        ///
        /// @param aFlushLayout flushes layout if true. Otherwise, no flush occurs.
        /// @see nsIDOMWindow::scrollX/Y
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScrollXY([MarshalAs(UnmanagedType.Bool)] bool aFlushLayout, out int aScrollX, out int aScrollY);
		
		/// <summary>
        /// Get IME open state. TRUE means 'Open', otherwise, 'Close'.
        /// This property works only when IMEEnabled is IME_STATUS_ENABLED.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIMEIsOpenAttribute();
		
		/// <summary>
        /// Get IME status, see above IME_STATUS_* definitions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetIMEStatusAttribute();
		
		/// <summary>
        /// Get the number of screen pixels per CSS pixel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetScreenPixelsPerCSSPixelAttribute();
		
		/// <summary>
        /// Dispatches aEvent via the nsIPresShell object of the window's document.
        /// The event is dispatched to aTarget, which should be an object
        /// which implements nsIContent interface (#element, #text, etc).
        ///
        /// Cannot be accessed from unprivileged context (not
        /// content-accessible) Will throw a DOM security error if called
        /// without UniversalXPConnect privileges.
        ///
        /// @note Event handlers won't get aEvent as parameter, but a similar event.
        /// Also, aEvent should not be reused.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DispatchDOMEventViaPresShell([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTarget, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aEvent, [MarshalAs(UnmanagedType.Bool)] bool aTrusted);
		
		/// <summary>
        ///in JSObjectPtr aObj </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetClassName();
		
		/// <summary>
        /// Generate a content command event.
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        ///
        /// @param aType Type of command content event to send.  Can be one of "cut",
        /// "copy", "paste", "delete", "undo", "redo", or "pasteTransferable".
        /// @param aTransferable an instance of nsITransferable when aType is
        /// "pasteTransferable"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendContentCommandEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, [MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable);
		
		/// <summary>
        /// Synthesize a composition event to the window.
        ///
        /// Cannot be accessed from unprivileged context (not content-accessible)
        /// Will throw a DOM security error if called without UniversalXPConnect
        /// privileges.
        ///
        /// @param aType The event type: "compositionstart" or "compositionend".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendCompositionEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>
        /// NOTE: These values must be same to NS_TEXTRANGE_* in nsGUIEvent.h
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendTextEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aCompositionString, int aFirstClauseLength, uint aFirstClauseAttr, int aSecondClauseLength, uint aSecondClauseAttr, int aThirdClauseLength, uint aThirdClauseAttr, int aCaretStart, int aCaretLength);
		
		/// <summary>
        /// Synthesize a query content event.
        ///
        /// @param aType  On of the following const values.  And see also each comment
        /// for the other parameters and the result.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIQueryContentEventResult SendQueryContentEvent(uint aType, uint aOffset, uint aLength, int aX, int aY);
		
		/// <summary>
        /// Synthesize a selection set event to the window.
        ///
        /// This sets the selection as the specified information.
        ///
        /// @param aOffset  The caret offset of the selection start.
        /// @param aLength  The length of the selection.  If this is too long, the
        /// extra length is ignored.
        /// @param aReverse If true, the selection set from |aOffset + aLength| to
        /// |aOffset|.  Otherwise, set from |aOffset| to
        /// |aOffset + aLength|.
        /// @return True, if succeeded.  Otherwise, false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SendSelectionSetEvent(uint aOffset, uint aLength, [MarshalAs(UnmanagedType.Bool)] bool aReverse);
		
		/// <summary>
        /// Perform the equivalent of:
        /// window.getComputedStyle(aElement, aPseudoElement).
        /// getPropertyValue(aPropertyName)
        /// except that, when the link whose presence in history is allowed to
        /// influence aElement's style is visited, get the value the property
        /// would have if allowed all properties to change as a result of
        /// :visited selectors (except for cases where getComputedStyle uses
        /// data from the frame).
        ///
        /// This is easier to implement than adding our property restrictions
        /// to this API, and is sufficient for the present testing
        /// requirements (which are essentially testing 'color').
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVisitedDependentComputedStyle([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPseudoElement, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPropertyName, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        ///obj </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetParent();
		
		/// <summary>
        /// Get the id of the outer window of this window.  This will never throw.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetOuterWindowIDAttribute();
		
		/// <summary>
        /// Get the id of the current inner window of this window.  If there
        /// is no current inner window, throws NS_ERROR_NOT_AVAILABLE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCurrentInnerWindowIDAttribute();
		
		/// <summary>
        /// Put the window into a state where scripts are frozen and events
        /// suppressed, for use when the window has launched a modal prompt.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnterModalState();
		
		/// <summary>
        /// Resume normal window state, where scripts can run and events are
        /// delivered.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LeaveModalState();
		
		/// <summary>
        /// Same as enterModalState, but returns the window associated with the
        /// current JS context.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow EnterModalStateWithWindow();
		
		/// <summary>
        /// Same as leaveModalState, but takes a window associated with the active
        /// context when enterModalStateWithWindow was called. The currently context
        /// might be different at the moment (see bug 621764).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LeaveModalStateWithWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Is the window is in a modal state? [See enterModalState()]
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsInModalState();
		
		/// <summary>
        /// Suspend/resume timeouts on this window and its descendant windows.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SuspendTimeouts();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeTimeouts();
		
		/// <summary>
        /// What type of layer manager the widget associated with this window is
        /// using. "Basic" is unaccelerated; other types are accelerated. Throws an
        /// error if there is no widget associated with this window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLayerManagerTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLayerManagerType);
		
		/// <summary>
        /// The DPI of the display
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDisplayDPIAttribute();
		
		/// <summary>
        /// Return the outer window with the given ID, if any.  Can return null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetOuterWindowWithId(uint aOuterWindowID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RenderDocument(nsConstRect aRect, uint aFlags, nscolor aBackgroundColor, System.IntPtr aThebesContext);
		
		/// <summary>
        /// advanceTimeAndRefresh allows the caller to take over the refresh
        /// driver timing for a window.  A call to advanceTimeAndRefresh does
        /// three things:
        /// (1) It marks the refresh driver for this presentation so that it
        /// no longer refreshes on its own, but is instead driven entirely
        /// by the caller (except for the refresh that happens when a
        /// document comes out of the bfcache).
        /// (2) It advances the refresh driver's current refresh time by the
        /// argument given.  Negative advances are permitted.
        /// (3) It does a refresh (i.e., notifies refresh observers) at that
        /// new time.
        ///
        /// Note that this affects other connected docshells of the same type
        /// in the same docshell tree, such as parent frames.
        ///
        /// When callers have completed their use of advanceTimeAndRefresh,
        /// they must call restoreNormalRefresh.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AdvanceTimeAndRefresh(int aMilliseconds);
		
		/// <summary>
        /// Undoes the effects of advanceTimeAndRefresh.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RestoreNormalRefresh();
		
		/// <summary>
        /// Method for testing nsStyleAnimation::ComputeDistance.
        ///
        /// Returns the distance between the two values as reported by
        /// nsStyleAnimation::ComputeDistance for the given element and
        /// property.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double ComputeAnimationDistance([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element, [MarshalAs(UnmanagedType.LPStruct)] nsAString property, [MarshalAs(UnmanagedType.LPStruct)] nsAString value1, [MarshalAs(UnmanagedType.LPStruct)] nsAString value2);
		
		/// <summary>
        /// Get the type of the currently focused html input, if any.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFocusedInputTypeAttribute();
		
		/// <summary>
        /// Given a view ID from the compositor process, retrieve the element
        /// associated with a view. For scrollpanes for documents, the root
        /// element of the document is returned.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement FindElementWithViewId(System.IntPtr aId);
		
		/// <summary>
        /// Checks the layer tree for this window and returns true
        /// if all layers have transforms that are translations by integers,
        /// no leaf layers overlap, and the union of the leaf layers is exactly
        /// the bounds of the window. Always returns true in non-DEBUG builds.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool LeafLayersPartitionWindow();
	}
}
