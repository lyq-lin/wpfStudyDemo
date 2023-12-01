using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
	public class TaskModel
	{
		public TaskListModel Parent { get; set; }
		public string TaskName { get; set; }
	}
}
