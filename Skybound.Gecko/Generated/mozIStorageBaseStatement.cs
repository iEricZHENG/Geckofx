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
// Generated by IDLImporter from file mozIStorageBaseStatement.idl
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
	
	
	/// <summary>
    /// The base interface for both pure asynchronous storage statements
    /// (mozIStorageAsyncStatement) and 'classic' storage statements
    /// (mozIStorageStatement) that can be used for both synchronous and asynchronous
    /// purposes.
    /// </summary>
	[ComImport()]
	[Guid("da2ec336-fbbb-4ba1-9778-8c9825980d01")]
	public interface mozIStorageBaseStatement : mozIStorageBindingParams
	{
		
		/// <summary>
        /// Finalizes a statement so you can successfully close a database connection.
        /// Once a statement has been finalized it can no longer be used for any
        /// purpose.
        ///
        /// Statements are implicitly finalized when their reference counts hits zero.
        /// If you are a native (C++) caller this is accomplished by setting all of
        /// your nsCOMPtr instances to be NULL.  If you are operating from JavaScript
        /// code then you cannot rely on this behavior because of the involvement of
        /// garbage collection.
        ///
        /// When finalizing an asynchronous statement you do not need to worry about
        /// whether the statement has actually been executed by the asynchronous
        /// thread; you just need to call finalize after your last call to executeAsync
        /// involving the statement.  However, you do need to use asyncClose instead of
        /// close on the connection if any statements have been used asynchronously.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finalize();
		
		/// <summary>
        /// Bind the given value at the given numeric index.
        ///
        /// @param aParamIndex
        /// 0-based index, 0 corresponding to the first numbered argument or
        /// "?1".
        /// @param aValue
        /// Argument value.
        /// @param aValueSize
        /// Length of aValue in bytes.
        /// @{
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindUTF8StringParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindStringParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindDoubleParameter(uint aParamIndex, double aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindInt32Parameter(uint aParamIndex, int aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindInt64Parameter(uint aParamIndex, long aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindNullParameter(uint aParamIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] System.IntPtr[] aValue, uint aValueSize);
		
		/// <summary>
        /// Binds the array of parameters to the statement.  When executeAsync is
        /// called, all the parameters in aParameters are bound and then executed.
        ///
        /// @param aParameters
        /// The array of parameters to bind to the statement upon execution.
        ///
        /// @note This is only works on statements being used asynchronously.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindParameters(mozIStorageBindingParamsArray aParameters);
		
		/// <summary>
        /// Creates a new mozIStorageBindingParamsArray that can be used to bind
        /// multiple sets of data to a statement with bindParameters.
        ///
        /// @return a mozIStorageBindingParamsArray that multiple sets of parameters
        /// can be bound to.
        ///
        /// @note This is only useful for statements being used asynchronously.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageBindingParamsArray NewBindingParamsArray();
		
		/// <summary>
        /// Execute a query asynchronously using any currently bound parameters.  This
        /// statement can be reused immediately, and reset does not need to be called.
        ///
        /// @note If you have any custom defined functions, they must be re-entrant
        /// since they can be called on multiple threads.
        ///
        /// @param aCallback [optional]
        /// The callback object that will be notified of progress, errors, and
        /// completion.
        /// @return an object that can be used to cancel the statements execution.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStoragePendingStatement ExecuteAsync(mozIStorageStatementCallback aCallback);
		
		/// <summary>
        /// Find out whether the statement is usable (has not been finalized).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStateAttribute();
		
		/// <summary>
        /// Escape a string for SQL LIKE search.
        ///
        /// @note Consumers will have to use same escape char when doing statements
        /// such as:   ...LIKE '?1' ESCAPE '/'...
        ///
        /// @param aValue
        /// The string to escape for SQL LIKE.
        /// @param aEscapeChar
        /// The escape character.
        /// @return an AString of an escaped version of aValue
        /// (%, _ and the escape char are escaped with the escape char)
        /// For example, we will convert "foo/bar_baz%20cheese"
        /// into "foo//bar/_baz/%20cheese" (if the escape char is '/').
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EscapeStringForLIKE([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue, char aEscapeChar, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
	}
}
