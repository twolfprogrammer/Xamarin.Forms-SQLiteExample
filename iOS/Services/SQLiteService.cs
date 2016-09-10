using System;
using System.IO;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteExample.iOS.SQLiteService))]
namespace SQLiteExample.iOS {
	public class SQLiteService : ISQLiteService {
		string GetPath(string databaseName) {
			if (string.IsNullOrWhiteSpace(databaseName)) {
				throw new ArgumentException("Invalid database name", nameof(databaseName));
			}
			var sqliteFilename = $"{databaseName}.db3";
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine(documentsPath, "..", "Library");
			var path = Path.Combine(libraryPath, sqliteFilename);
			return path;
		}

		public SQLiteConnection GetConnection(string databaseName) {
			return new SQLiteConnection(GetPath(databaseName));
		}

		public long GetSize(string databaseName) {
			var fileInfo = new FileInfo(GetPath(databaseName));
			return fileInfo != null ? fileInfo.Length : 0;
		}
	}
}

