using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ValidationDemo
{
	internal class MainViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string property = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}

		private string _searchText = String.Empty;
		private string? _errorMessage;

		private CustomValidator _customValidator = new();

		public MainViewModel()
		{

		}

		public string SearchText
		{
			get { return _searchText; }
			set
			{
				_searchText = value;
				this.Valid(_searchText);
				this.OnPropertyChanged();
			}
		}

		private void Valid(string searchText)
		{
			if (!"YCode".Equals(searchText))
			{
				ErrorMessage = _customValidator[nameof(this.SearchText)];
			}
			else
			{
				ErrorMessage = String.Empty;
			}
		}

		public string? ErrorMessage
		{
			get { return _errorMessage; }
			set
			{
				_errorMessage = value;
				this.OnPropertyChanged();
			}
		}
	}
}
