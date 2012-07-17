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
// Generated by IDLImporter from file nsIDOMMozTouchEvent.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>nsIDOMMozTouchEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("268da07b-4c41-4deb-96a2-10985644e6b0")]
	public interface nsIDOMMozTouchEvent : nsIDOMMouseEvent
	{
		
		/// <summary>
        /// The name of the event (case-insensitive). The name must be an XML
        /// name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// Used to indicate the EventTarget to which the event was originally
        /// dispatched.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTargetAttribute();
		
		/// <summary>
        /// Used to indicate the EventTarget whose EventListeners are currently
        /// being processed. This is particularly useful during capturing and
        /// bubbling.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTargetAttribute();
		
		/// <summary>
        /// Used to indicate which phase of event flow is currently being
        /// evaluated.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhaseAttribute();
		
		/// <summary>
        /// Used to indicate whether or not an event is a bubbling event. If the
        /// event can bubble the value is true, else the value is false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubblesAttribute();
		
		/// <summary>
        /// Used to indicate whether or not an event can have its default action
        /// prevented. If the default action can be prevented the value is true,
        /// else the value is false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelableAttribute();
		
		/// <summary>
        /// Used to specify the time (in milliseconds relative to the epoch) at
        /// which the event was created. Due to the fact that some systems may
        /// not provide this information the value of timeStamp may be not
        /// available for all events. When not available, a value of 0 will be
        /// returned. Examples of epoch time are the time of the system start or
        /// 0:0:0 UTC 1st January 1970.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetTimeStampAttribute();
		
		/// <summary>
        /// The stopPropagation method is used prevent further propagation of an
        /// event during event flow. If this method is called by any
        /// EventListener the event will cease propagating through the tree. The
        /// event will complete dispatch to all listeners on the current
        /// EventTarget before event flow stops. This method may be used during
        /// any stage of event flow.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		/// <summary>
        /// If an event is cancelable, the preventDefault method is used to
        /// signify that the event is to be canceled, meaning any default action
        /// normally taken by the implementation as a result of the event will
        /// not occur. If, during any stage of event flow, the preventDefault
        /// method is called the event is canceled. Any default action associated
        /// with the event will not occur. Calling this method for a
        /// non-cancelable event has no effect. Once preventDefault has been
        /// called it will remain in effect throughout the remainder of the
        /// event's propagation. This method may be used during any stage of
        /// event flow.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		/// <summary>
        /// The initEvent method is used to initialize the value of an Event
        /// created through the DocumentEvent interface. This method may only be
        /// called before the Event has been dispatched via the dispatchEvent
        /// method, though it may be called multiple times during that phase if
        /// necessary. If called multiple times the final invocation takes
        /// precedence. If called from a subclass of Event interface only the
        /// values specified in the initEvent method are modified, all other
        /// attributes are left unchanged.
        ///
        /// @param   eventTypeArg Specifies the event type. This type may be
        /// any event type currently defined in this
        /// specification or a new event type.. The string
        /// must be an XML name.
        /// Any new event type must not begin with any
        /// upper, lower, or mixed case version of the
        /// string "DOM". This prefix is reserved for
        /// future DOM event sets. It is also strongly
        /// recommended that third parties adding their
        /// own events use their own prefix to avoid
        /// confusion and lessen the probability of
        /// conflicts with other new events.
        /// @param   canBubbleArg Specifies whether or not the event can bubble.
        /// @param   cancelableArg Specifies whether or not the event's default
        /// action can be prevented.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase eventTypeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg);
		
		/// <summary>
        /// Used to indicate whether preventDefault() has been called for this event.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetDefaultPreventedAttribute();
		
		/// <summary>
        /// Prevents other event listeners from being triggered and,
        /// unlike Event.stopPropagation() its effect is immediate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopImmediatePropagation();
		
		/// <summary>
        /// The nsIDOMUIEvent interface is the datatype for all UI events in the
        /// Document Object Model.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Events/
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetViewAttribute();
		
		/// <summary>Member GetDetailAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetDetailAttribute();
		
		/// <summary>Member InitUIEvent </summary>
		/// <param name='typeArg'> </param>
		/// <param name='canBubbleArg'> </param>
		/// <param name='cancelableArg'> </param>
		/// <param name='viewArg'> </param>
		/// <param name='detailArg'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitUIEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, int detailArg);
		
		/// <summary>Member GetLayerXAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetLayerXAttribute();
		
		/// <summary>Member GetLayerYAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetLayerYAttribute();
		
		/// <summary>Member GetPageXAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetPageXAttribute();
		
		/// <summary>Member GetPageYAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetPageYAttribute();
		
		/// <summary>Member GetWhichAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetWhichAttribute();
		
		/// <summary>Member GetRangeParentAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetRangeParentAttribute();
		
		/// <summary>Member GetRangeOffsetAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetRangeOffsetAttribute();
		
		/// <summary>Member GetCancelBubbleAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelBubbleAttribute();
		
		/// <summary>Member SetCancelBubbleAttribute </summary>
		/// <param name='aCancelBubble'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCancelBubbleAttribute([MarshalAs(UnmanagedType.U1)] bool aCancelBubble);
		
		/// <summary>Member GetIsCharAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsCharAttribute();
		
		/// <summary>
        /// The nsIDOMMouseEvent interface is the datatype for all mouse events
        /// in the Document Object Model.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Events/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScreenXAttribute();
		
		/// <summary>Member GetScreenYAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScreenYAttribute();
		
		/// <summary>Member GetMozMovementXAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetMozMovementXAttribute();
		
		/// <summary>Member GetMozMovementYAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetMozMovementYAttribute();
		
		/// <summary>Member GetClientXAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientXAttribute();
		
		/// <summary>Member GetClientYAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientYAttribute();
		
		/// <summary>Member GetCtrlKeyAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCtrlKeyAttribute();
		
		/// <summary>Member GetShiftKeyAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetShiftKeyAttribute();
		
		/// <summary>Member GetAltKeyAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetAltKeyAttribute();
		
		/// <summary>Member GetMetaKeyAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetMetaKeyAttribute();
		
		/// <summary>Member GetButtonAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetButtonAttribute();
		
		/// <summary>Member GetRelatedTargetAttribute </summary>
		/// <returns>A nsIDOMEventTarget</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetRelatedTargetAttribute();
		
		/// <summary>Member InitMouseEvent </summary>
		/// <param name='typeArg'> </param>
		/// <param name='canBubbleArg'> </param>
		/// <param name='cancelableArg'> </param>
		/// <param name='viewArg'> </param>
		/// <param name='detailArg'> </param>
		/// <param name='screenXArg'> </param>
		/// <param name='screenYArg'> </param>
		/// <param name='clientXArg'> </param>
		/// <param name='clientYArg'> </param>
		/// <param name='ctrlKeyArg'> </param>
		/// <param name='altKeyArg'> </param>
		/// <param name='shiftKeyArg'> </param>
		/// <param name='metaKeyArg'> </param>
		/// <param name='buttonArg'> </param>
		/// <param name='relatedTargetArg'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitMouseEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, [MarshalAs(UnmanagedType.U1)] bool ctrlKeyArg, [MarshalAs(UnmanagedType.U1)] bool altKeyArg, [MarshalAs(UnmanagedType.U1)] bool shiftKeyArg, [MarshalAs(UnmanagedType.U1)] bool metaKeyArg, ushort buttonArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget relatedTargetArg);
		
		/// <summary>
        /// ranges between 0.0 and 1.0
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new float GetMozPressureAttribute();
		
		/// <summary>Member GetMozInputSourceAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetMozInputSourceAttribute();
		
		/// <summary>Member InitNSMouseEvent </summary>
		/// <param name='typeArg'> </param>
		/// <param name='canBubbleArg'> </param>
		/// <param name='cancelableArg'> </param>
		/// <param name='viewArg'> </param>
		/// <param name='detailArg'> </param>
		/// <param name='screenXArg'> </param>
		/// <param name='screenYArg'> </param>
		/// <param name='clientXArg'> </param>
		/// <param name='clientYArg'> </param>
		/// <param name='ctrlKeyArg'> </param>
		/// <param name='altKeyArg'> </param>
		/// <param name='shiftKeyArg'> </param>
		/// <param name='metaKeyArg'> </param>
		/// <param name='buttonArg'> </param>
		/// <param name='relatedTargetArg'> </param>
		/// <param name='pressure'> </param>
		/// <param name='inputSourceArg'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitNSMouseEvent(
					[MarshalAs(UnmanagedType.LPStruct)] nsAStringBase typeArg, 
					[MarshalAs(UnmanagedType.U1)] bool canBubbleArg, 
					[MarshalAs(UnmanagedType.U1)] bool cancelableArg, 
					[MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, 
					int detailArg, 
					int screenXArg, 
					int screenYArg, 
					int clientXArg, 
					int clientYArg, 
					[MarshalAs(UnmanagedType.U1)] bool ctrlKeyArg, 
					[MarshalAs(UnmanagedType.U1)] bool altKeyArg, 
					[MarshalAs(UnmanagedType.U1)] bool shiftKeyArg, 
					[MarshalAs(UnmanagedType.U1)] bool metaKeyArg, 
					ushort buttonArg, 
					[MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget relatedTargetArg, 
					float pressure, 
					ushort inputSourceArg);
		
		/// <summary>Member GetStreamIdAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetStreamIdAttribute();
		
		/// <summary>Member InitMozTouchEvent </summary>
		/// <param name='typeArg'> </param>
		/// <param name='canBubbleArg'> </param>
		/// <param name='cancelableArg'> </param>
		/// <param name='viewArg'> </param>
		/// <param name='detailArg'> </param>
		/// <param name='screenXArg'> </param>
		/// <param name='screenYArg'> </param>
		/// <param name='clientXArg'> </param>
		/// <param name='clientYArg'> </param>
		/// <param name='ctrlKeyArg'> </param>
		/// <param name='altKeyArg'> </param>
		/// <param name='shiftKeyArg'> </param>
		/// <param name='metaKeyArg'> </param>
		/// <param name='buttonArg'> </param>
		/// <param name='relatedTargetArg'> </param>
		/// <param name='streamIdArg'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitMozTouchEvent(
					[MarshalAs(UnmanagedType.LPStruct)] nsAStringBase typeArg, 
					[MarshalAs(UnmanagedType.U1)] bool canBubbleArg, 
					[MarshalAs(UnmanagedType.U1)] bool cancelableArg, 
					[MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, 
					int detailArg, 
					int screenXArg, 
					int screenYArg, 
					int clientXArg, 
					int clientYArg, 
					[MarshalAs(UnmanagedType.U1)] bool ctrlKeyArg, 
					[MarshalAs(UnmanagedType.U1)] bool altKeyArg, 
					[MarshalAs(UnmanagedType.U1)] bool shiftKeyArg, 
					[MarshalAs(UnmanagedType.U1)] bool metaKeyArg, 
					ushort buttonArg, 
					[MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget relatedTargetArg, 
					uint streamIdArg);
	}
}
