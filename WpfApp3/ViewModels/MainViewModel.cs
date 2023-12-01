using System.IO;

namespace WpfApp3
{
	internal class MainViewModel : BaseViewModel
	{
		private TreeViewModel _rootModel;

		public TreeViewModel RootModel
		{
			get { return _rootModel; }
			set { _rootModel = value; RaisePropertyChanged(); }
		}

		public MainViewModel()
		{
			RootModel = new TreeViewModel();
			RootModel.Path = $@"D:\PersonalFile\C&C++Study\Test";
			RootModel.Name = $@"D:\PersonalFile\C&C++Study\Test";

			RootModel = LoadData(RootModel);
		}

		public TreeViewModel LoadData(TreeViewModel parent = null)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(parent.Path);

			var ds = directoryInfo.GetDirectories();
			foreach (var d in ds)
			{
				TreeViewModel sub = new TreeViewModel() { Path = d.FullName, Name = d.Name };
				var result = LoadData(sub);
				parent.Childrens.Add(result);
			}

			var fs = directoryInfo.GetFiles();
			foreach (var f in fs)
			{
				TreeViewModel file = new TreeViewModel() { Path = f.FullName, Name = f.Name };
				parent.Childrens.Add(file);
			}

			return parent;
		}
	}
}
