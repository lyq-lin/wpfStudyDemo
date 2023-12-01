using System.Collections.ObjectModel;

namespace WpfApp1
{
	public class TaskListModel : BaseViewModel
	{
		private ObservableCollection<TaskModel> _childrens;

		public ObservableCollection<TaskModel> Childrens
		{
			get { return _childrens; }
			set { _childrens = value; RaisePropertyChanged(); }
		}

		public TaskListModel()
		{
			Childrens = new ObservableCollection<TaskModel>();
		}
	}
}
