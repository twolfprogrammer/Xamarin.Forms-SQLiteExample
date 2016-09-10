using System;
using SQLite;

namespace SQLiteExample {
	public interface ISQLiteService {
		SQLiteConnection GetConnection(string databaseName);
		long GetSize(string databaseName);
	}
}

