// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: ISimpleDOMText.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file ISimpleDOMText.idl
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
	
	
	/// <summary>ISimpleDOMText </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4e747be5-2052-4265-8af0-8ecad7aad1c0")]
	public interface ISimpleDOMText
	{
		
		/// <summary>Gets a DomText </summary>
		/// <returns>A System.String </returns>
		string DomText
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
		
		/// <summary>Member Get_clippedSubstringBounds </summary>
		/// <param name='startIndex'> </param>
		/// <param name='endIndex'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Get_clippedSubstringBounds(uint startIndex, uint endIndex, out int x, out int y, out int width, out int height);
		
		/// <summary>Member Get_unclippedSubstringBounds </summary>
		/// <param name='startIndex'> </param>
		/// <param name='endIndex'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Get_unclippedSubstringBounds(uint startIndex, uint endIndex, out int x, out int y, out int width, out int height);
		
		/// <summary>Member ScrollToSubstring </summary>
		/// <param name='startIndex'> </param>
		/// <param name='endIndex'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint ScrollToSubstring(uint startIndex, uint endIndex);
		
		/// <summary>Gets a FontFamily </summary>
		/// <returns>A System.String </returns>
		string FontFamily
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
	}
}