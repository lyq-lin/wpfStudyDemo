using System.Collections.ObjectModel;

namespace WpfApp4
{
	internal class MainViewModel : BaseViewModel
	{
		private ObservableCollection<ItemViewModel> _rootModel;

		public MainViewModel()
		{
			RootModel = new ObservableCollection<ItemViewModel>()
			{
				new ItemViewModel() {Type = "UcTemplate1"},
				new ItemViewModel(){ Type = "UcTemplate2"},
				new ItemViewModel(){ Type = "UcTemplate3"}
			};
		}

		public ObservableCollection<ItemViewModel> RootModel
		{
			get { return _rootModel; }
			set { _rootModel = value; RaisePropertyChanged(); }
		}

	}
}
