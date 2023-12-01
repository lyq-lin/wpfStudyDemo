using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp5
{
	class ValueChangedCommand : ICommand
	{
		private readonly MainViewModel _mainViewModel;

		public event EventHandler? CanExecuteChanged;

		public ValueChangedCommand(MainViewModel mainViewModel)
		{
			_mainViewModel = mainViewModel;
		}

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			if (parameter is TextBox tb && tb.DataContext is BaseViewModel vm)
			{
				_mainViewModel.ValueChanged(tb.Text, vm);
			}
		}
	}
}
