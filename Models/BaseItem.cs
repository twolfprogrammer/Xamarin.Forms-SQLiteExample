using SQLite;

namespace SQLiteExample {
	public class BaseItem {
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
	}
}

