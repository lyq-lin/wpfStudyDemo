using System.Collections.ObjectModel;
using System.Windows.Data;

namespace WpfApp6
{
	class MainViewModel : BaseViewModel
	{
		private string _searchText = string.Empty;

		public MainViewModel()
		{
			DataSource.Add(new() { Name = "YCode1", Group = "Basic" });
			DataSource.Add(new() { Name = "YCode23", Group = "Basic" });
			DataSource.Add(new() { Name = "Jody13", Group = "Custom" });

			CollectionViewSource.GetDefaultView(DataSource).GroupDescriptions.Add(new PropertyGroupDescription("Group"));
		}

		public string SearchText
		{
			get { return _searchText; }
			set { _searchText = value; this.OnPropertyChanged(); }
		}


		public ObservableCollection<DataSourceViewModel> DataSource { get; set; } = new();
	}
}
