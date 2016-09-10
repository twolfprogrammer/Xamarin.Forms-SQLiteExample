using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SQLiteExample {
	public class BaseViewModel : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged([CallerMemberName] string propertyName = "") {
			var handler = PropertyChanged;
			if (handler == null) return;
			handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

