using WpfApp1;

namespace WpfApp1
{
	public class MainViewModel : BaseViewModel
	{
		private TaskListModel _taskList;

		public TaskListModel TaskList
		{
			get { return _taskList; }
			set { _taskList = value; RaisePropertyChanged(); }
		}

		public DelegateTaskCommand AddTaskCommand { get; set; }

		public MainViewModel()
		{
			TaskList = new TaskListModel();
			TaskList.Childrens.Add(new TaskModel() { TaskName = "User" });
			TaskList.Childrens.Add(new TaskModel() { TaskName = "Role" });

			AddTaskCommand = new DelegateTaskCommand();
			AddTaskCommand.Action = (o) =>
			{
				TaskList.Childrens.Add(new TaskModel() { TaskName = "Task1" });
			};
		}
	}
}
