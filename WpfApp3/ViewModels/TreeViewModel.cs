using System.Collections.ObjectModel;

namespace WpfApp3
{
	internal class TreeViewModel : BaseViewModel
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; RaisePropertyChanged(); }
		}

		private string _path;

		public string Path
		{
			get { return _path; }
			set { _path = value; RaisePropertyChanged(); }
		}

		public ObservableCollection<TreeViewModel> Childrens { get; set; } = new ObservableCollection<TreeViewModel>();

	}
}
