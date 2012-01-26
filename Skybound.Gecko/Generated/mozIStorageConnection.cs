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
// Generated by IDLImporter from file mozIStorageConnection.idl
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
    /// mozIStorageConnection represents a database connection attached to
    /// a specific file or to the in-memory data storage.  It is the
    /// primary interface for interacting with a database, including
    /// creating prepared statements, executing SQL, and examining database
    /// errors.
    ///
    /// @threadsafe
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ad035628-4ffb-42ff-a256-0ed9e410b859")]
	public interface mozIStorageConnection
	{
		
		/// <summary>
        /// Closes a database connection.  Callers must finalize all statements created
        /// for this connection prior to calling this method.  It is illegal to use
        /// call this method if any asynchronous statements have been executed on this
        /// connection.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// If any statement has been executed asynchronously on this object.
        /// @throws NS_ERROR_UNEXPECTED
        /// If is called on a thread other than the one that opened it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Asynchronously closes a database connection, allowing all pending
        /// asynchronous statements to complete first.
        ///
        /// @param aCallback [optional]
        /// A callback that will be notified when the close is completed.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// If is called on a thread other than the one that opened it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncClose(mozIStorageCompletionCallback aCallback);
		
		/// <summary>
        /// Clones a database and makes the clone read only if needed.
        ///
        /// @note If your connection is already read-only, you will get a read-only
        /// clone.
        /// @note Due to a bug in SQLite, if you use the shared cache (openDatabase),
        /// you end up with the same privileges as the first connection opened
        /// regardless of what is specified in aReadOnly.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// If this connection is a memory database.
        ///
        /// @param aReadOnly
        /// If true, the returned database should be put into read-only mode.
        /// Defaults to false.
        /// @return the cloned database connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageConnection Clone([MarshalAs(UnmanagedType.Bool)] bool aReadOnly);
		
		/// <summary>
        /// Indicates if the connection is open and ready to use.  This will be false
        /// if the connection failed to open, or it has been closed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetConnectionReadyAttribute();
		
		/// <summary>
        /// The current database nsIFile.  Null if the database
        /// connection refers to an in-memory database.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetDatabaseFileAttribute();
		
		/// <summary>
        /// lastInsertRowID returns the row ID from the last INSERT
        /// operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLastInsertRowIDAttribute();
		
		/// <summary>
        /// The last error SQLite error code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLastErrorAttribute();
		
		/// <summary>
        /// The last SQLite error as a string (in english, straight from the
        /// sqlite library).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLastErrorStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aLastErrorString);
		
		/// <summary>
        /// The schema version of the database.  This should not be used until the
        /// database is ready.  The schema will be reported as zero if it is not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSchemaVersionAttribute();
		
		/// <summary>
        /// The schema version of the database.  This should not be used until the
        /// database is ready.  The schema will be reported as zero if it is not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSchemaVersionAttribute(int aSchemaVersion);
		
		/// <summary>
        /// Create a mozIStorageStatement for the given SQL expression.  The
        /// expression may use ? to indicate sequential numbered arguments,
        /// ?1, ?2 etc. to indicate specific numbered arguments or :name and
        /// $var to indicate named arguments.
        ///
        /// @param aSQLStatement
        /// The SQL statement to execute.
        /// @return a new mozIStorageStatement
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageStatement CreateStatement([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aSQLStatement);
		
		/// <summary>
        /// Create an asynchronous statement (mozIStorageAsyncStatement) for the given
        /// SQL expression.  An asynchronous statement can only be used to dispatch
        /// asynchronous requests to the asynchronous execution thread and cannot be
        /// used to take any synchronous actions on the database.
        ///
        /// The expression may use ? to indicate sequential numbered arguments,
        /// ?1, ?2 etc. to indicate specific numbered arguments or :name and
        /// $var to indicate named arguments.
        ///
        /// @param aSQLStatement
        /// The SQL statement to execute.
        /// @return a new mozIStorageAsyncStatement
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageAsyncStatement CreateAsyncStatement([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aSQLStatement);
		
		/// <summary>
        /// Execute a SQL expression, expecting no arguments.
        ///
        /// @param aSQLStatement  The SQL statement to execute
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExecuteSimpleSQL([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aSQLStatement);
		
		/// <summary>
        /// Execute an array of queries created with this connection asynchronously
        /// using any currently bound parameters.  The statements are ran wrapped in a
        /// transaction.  These statements can be reused immediately, and reset does
        /// not need to be called.
        ///
        /// Note:  If you have any custom defined functions, they must be re-entrant
        /// since they can be called on multiple threads.
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
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStoragePendingStatement ExecuteAsync([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] mozIStorageBaseStatement[] aStatements, uint aNumStatements, mozIStorageStatementCallback aCallback);
		
		/// <summary>
        /// Check if the given table exists.
        ///
        /// @param aTableName
        /// The table to check
        /// @return TRUE if table exists, FALSE otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool TableExists([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aTableName);
		
		/// <summary>
        /// Check if the given index exists.
        ///
        /// @param aIndexName   The index to check
        /// @return TRUE if the index exists, FALSE otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IndexExists([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aIndexName);
		
		/// <summary>
        /// Returns true if a transaction is active on this connection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetTransactionInProgressAttribute();
		
		/// <summary>
        /// Begin a new transaction.  sqlite default transactions are deferred.
        /// If a transaction is active, throws an error.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginTransaction();
		
		/// <summary>
        /// Begins a new transaction with the given type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginTransactionAs(int transactionType);
		
		/// <summary>
        /// Commits the current transaction.  If no transaction is active,
        /// @throws NS_ERROR_UNEXPECTED.
        /// @throws NS_ERROR_NOT_INITIALIZED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CommitTransaction();
		
		/// <summary>
        /// Rolls back the current transaction.  If no transaction is active,
        /// @throws NS_ERROR_UNEXPECTED.
        /// @throws NS_ERROR_NOT_INITIALIZED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RollbackTransaction();
		
		/// <summary>
        /// Create the table with the given name and schema.
        ///
        /// If the table already exists, NS_ERROR_FAILURE is thrown.
        /// (XXX at some point in the future it will check if the schema is
        /// the same as what is specified, but that doesn't happen currently.)
        ///
        /// @param aTableName
        /// The table name to be created, consisting of [A-Za-z0-9_], and
        /// beginning with a letter.
        /// @param aTableSchema
        /// The schema of the table; what would normally go between the parens
        /// in a CREATE TABLE statement: e.g., "foo  INTEGER, bar STRING".
        ///
        /// @throws NS_ERROR_FAILURE
        /// If the table already exists or could not be created for any other
        /// reason.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateTable([MarshalAs(UnmanagedType.LPStr)] string aTableName, [MarshalAs(UnmanagedType.LPStr)] string aTableSchema);
		
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
		void CreateFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aFunctionName, int aNumArguments, mozIStorageFunction aFunction);
		
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
		void CreateAggregateFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aFunctionName, int aNumArguments, mozIStorageAggregateFunction aFunction);
		
		/// <summary>
        /// Delete custom SQL function (simple or aggregate one).
        ///
        /// @param aFunctionName
        /// The name of function to remove.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFunction([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aFunctionName);
		
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
		
		/// <summary>
        /// Controls SQLITE_FCNTL_CHUNK_SIZE setting in sqlite. This helps avoid fragmentation
        /// by growing/shrinking the database file in SQLITE_FCNTL_CHUNK_SIZE increments. To
        /// conserve memory on systems short on storage space, this function will have no effect
        /// on mobile devices or if less than 500MiB of space is left available.
        ///
        /// @param aIncrement
        /// The database file will grow in multiples of chunkSize.
        /// @param aDatabaseName
        /// Sqlite database name. "" means pass NULL for zDbName to sqlite3_file_control.
        /// See http://sqlite.org/c3ref/file_control.html for more details.
        /// @throws NS_ERROR_FILE_TOO_BIG
        /// If the system is short on storage space.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGrowthIncrement(int aIncrement, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aDatabaseName);
	}
}
