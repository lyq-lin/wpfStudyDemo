using System;
using System.Windows.Input;

namespace WpfApp1
{
	public class DelegateTaskCommand : ICommand
	{
		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public Action<object> Action { get; set; }

		public void Execute(object? parameter)
		{
			Action?.Invoke(parameter);
		}
	}
}
