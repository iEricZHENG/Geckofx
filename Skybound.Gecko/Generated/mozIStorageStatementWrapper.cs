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
// Generated by IDLImporter from file mozIStorageStatementWrapper.idl
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

	
	
	/// <summary>mozIStorageStatementRow </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("02eeaf95-c3db-4182-9340-222c29f68f02")]
	public interface mozIStorageStatementRow
	{
	}
	
	/// <summary>
    /// for by-name access to rows
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e65fe6e2-2643-463c-97e2-27665efe2386")]
	public interface mozIStorageStatementParams
	{
	}
	
	/// <summary>
    /// @deprecated As of Mozilla 1.9.2.  Methods are already provided on
    /// mozIStorageStatement.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("eee6f7c9-5586-4eaf-b35c-dca987c4ffd1")]
	public interface mozIStorageStatementWrapper
	{
		
		/// <summary>
        /// Initialize this wrapper with aStatement.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Initialize(mozIStorageStatement aStatement);
		
		/// <summary>
        /// The statement that is wrapped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageStatement GetStatementAttribute();
		
		/// <summary>
        /// Step, reset, and execute the wrapped statement.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reset();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Step();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Execute();
		
		/// <summary>
        /// The current row.  Throws an exception if no row is currently
        /// available.  Useful only from script.  The value of this is only
        /// valid while the statement is still executing, and is still on the
        /// appropriate row.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageStatementRow GetRowAttribute();
		
		/// <summary>
        /// The parameters; these can be set in lieu of using the call
        /// notation on this.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageStatementParams GetParamsAttribute();
	}
}
