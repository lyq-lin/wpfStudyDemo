using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		public void RaisePropertyChanged([CallerMemberName] string propertty = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertty));
		}
	}
}
