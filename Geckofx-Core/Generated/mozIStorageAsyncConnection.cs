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
// Generated by IDLImporter from file mozIStorageAsyncConnection.idl
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
    /// mozIStorageAsyncConnection represents an asynchronous database
    /// connection attached to a specific file or to an in-memory data
    /// storage.  It is the primary interface for interacting with a
    /// database from the main thread, including creating prepared
    /// statements, executing SQL, and examining database errors.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0e661a1d-27ff-4e6b-ac5a-126314cef61a")]
	public interface mozIStorageAsyncConnection
	{
		
		/// <summary>
        /// Close this database connection, allowing all pending statements
        /// to complete first.
        ///
        /// @param aCallback [optional]
        /// A callback that will be notified when the close is completed,
        /// with the following arguments:
        /// - status: the status of the call
        /// - value: |null|
        ///
        /// @throws NS_ERROR_NOT_SAME_THREAD
        /// If is called on a thread other than the one that opened it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncClose(mozIStorageCompletionCallback aCallback);
		
		/// <summary>
        /// Clone a database and make the clone read only if needed.
        ///
        /// @param aReadOnly
        /// If true, the returned database should be put into read-only mode.
        ///
        /// @param aCallback
        /// A callback that will be notified when the operation is complete,
        /// with the following arguments:
        /// - status: the status of the operation
        /// - value: in case of success, an intance of
        /// mozIStorageAsyncConnection cloned from this one.
        ///
        /// @throws NS_ERROR_NOT_SAME_THREAD
        /// If is called on a thread other than the one that opened it.
        /// @throws NS_ERROR_UNEXPECTED
        /// If this connection is a memory database.
        ///
        /// @note If your connection is already read-only, you will get a read-only
        /// clone.
        /// @note Due to a bug in SQLite, if you use the shared cache
        /// (see mozIStorageService), you end up with the same privileges as the
        /// first connection opened regardless of what is specified in aReadOnly.
        /// @note The following pragmas are copied over to a read-only clone:
        /// - cache_size
        /// - temp_store
        /// The following pragmas are copied over to a writeable clone:
        /// - cache_size
        /// - temp_store
        /// - foreign_keys
        /// - journal_size_limit
        /// - synchronous
        /// - wal_autocheckpoint
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncClone([MarshalAs(UnmanagedType.U1)] bool aReadOnly, mozIStorageCompletionCallback aCallback);
		
		/// <summary>
        /// The current database nsIFile.  Null if the database
        /// connection refers to an in-memory database.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetDatabaseFileAttribute();
		
		/// <summary>
        /// Create an asynchronous statement for the given SQL. An
        /// asynchronous statement can only be used to dispatch asynchronous
        /// requests to the asynchronous execution thread and cannot be used
        /// to take any synchronous actions on the database.
        ///
        /// The expression may use ? to indicate sequential numbered arguments,
        /// ?1, ?2 etc. to indicate specific numbered arguments or :name and
        /// $var to indicate named arguments.
        ///
        /// @param aSQLStatement
        /// The SQL statement to execute.
        /// @return a new mozIStorageAsyncStatement
        /// @note The statement is created lazily on first execution.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageAsyncStatement CreateAsyncStatement([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSQLStatement);
		
		/// <summary>
        /// Execute an array of statements created with this connection using
        /// any currently bound parameters. When the array contains multiple
        /// statements, the execution is wrapped in a single
        /// transaction. These statements can be reused immediately, and
        /// reset does not need to be called.
        ///
        /// @param aStatements
        /// The array of statements to execute asynchronously, in the order they
        /// are given in the array.
        /// @param aNumStatements
        /// The number of statements in aStatements.
        /// @param aCallback [optional]
        /// The callback object that will be notified of progress, errors, and
        /// completion.
        /// @return an object that can be used to cancel the statements execution.
        ///
        /// @note If you have any custom defined functions, they must be
        /// re-entrant since they can be called on multiple threads.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStoragePendingStatement ExecuteAsync([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] mozIStorageBaseStatement[] aStatements, uint aNumStatements, mozIStorageStatementCallback aCallback);
		
		/// <summary>
        /// Create a new SQL function.  If you use your connection on multiple threads,
        /// your function needs to be threadsafe, or it should only be called on one
        /// thread.
        ///
        /// @param aFunctionName
        /// The name of function to create, as seen in SQL.
        /// @param aNumArguments
        /// The number of arguments the function takes. Pass -1 for
        /// variable-argument functions.
        /// @param aFunction
        /// The instance of mozIStorageFunction, which implements the function
        /// in question.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName, int aNumArguments, mozIStorageFunction aFunction);
		
		/// <summary>
        /// Create a new SQL aggregate function.  If you use your connection on
        /// multiple threads, your function needs to be threadsafe, or it should only
        /// be called on one thread.
        ///
        /// @param aFunctionName
        /// The name of aggregate function to create, as seen in SQL.
        /// @param aNumArguments
        /// The number of arguments the function takes. Pass -1 for
        /// variable-argument functions.
        /// @param aFunction
        /// The instance of mozIStorageAggreagteFunction, which implements the
        /// function in question.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateAggregateFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName, int aNumArguments, mozIStorageAggregateFunction aFunction);
		
		/// <summary>
        /// Delete custom SQL function (simple or aggregate one).
        ///
        /// @param aFunctionName
        /// The name of function to remove.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFunctionName);
		
		/// <summary>
        /// Sets a progress handler. Only one handler can be registered at a time.
        /// If you need more than one, you need to chain them yourself.  This progress
        /// handler should be threadsafe if you use this connection object on more than
        /// one thread.
        ///
        /// @param aGranularity
        /// The number of SQL virtual machine steps between progress handler
        /// callbacks.
        /// @param aHandler
        /// The instance of mozIStorageProgressHandler.
        /// @return previous registered handler.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageProgressHandler SetProgressHandler(int aGranularity, mozIStorageProgressHandler aHandler);
		
		/// <summary>
        /// Remove a progress handler.
        ///
        /// @return previous registered handler.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageProgressHandler RemoveProgressHandler();
	}
}
