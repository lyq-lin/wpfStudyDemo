using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WpfApp5
{
	class BaseViewModel : INotifyPropertyChanged
	{
		public Guid Id { get; init; } = Guid.NewGuid();

		private ObservableCollection<BaseViewModel> _children = new();


		public ObservableCollection<BaseViewModel> Children
		{
			get { return _children; }
			set { _children = value; this.OnPropertyChanged(); }
		}


		public event PropertyChangedEventHandler? PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string property = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}

		public IEnumerable<TViewModel> GetChildren<TViewModel>()
		{
			return this.Children.OfType<TViewModel>();
		}
	}
}
