using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WpfApp5
{
	class MainViewModel : BaseViewModel, IViewModelValueChanged
	{
		private ViewModel1? _selectedVm;

		public MainViewModel()
		{
			Root = new();
			ViewModel1 v1 = new() { Name = "YCode1", Gender = "Male", Class = "999" };
			v1.Properties.Add(new(v1) { Title = nameof(v1.Name), Value = v1.Name });
			v1.Properties.Add(new(v1) { Title = nameof(v1.Gender), Value = v1.Gender });
			v1.Properties.Add(new(v1) { Title = nameof(v1.Class), Value = v1.Class });

			ViewModel1 v2 = new() { Name = "YCode2", Gender = "Female", Class = "888" };
			v2.Properties.Add(new(v2) { Title = nameof(v2.Name), Value = v2.Name });
			v2.Properties.Add(new(v2) { Title = nameof(v2.Gender), Value = v2.Gender });
			v2.Properties.Add(new(v2) { Title = nameof(v2.Class), Value = v2.Class });

			ViewModel1 v3 = new() { Name = "YCode3", Gender = "Male", Class = "777" };
			v3.Properties.Add(new(v3) { Title = nameof(v3.Name), Value = v3.Name });
			v3.Properties.Add(new(v3) { Title = nameof(v3.Gender), Value = v3.Gender });
			v3.Properties.Add(new(v3) { Title = nameof(v3.Class), Value = v3.Class });

			Root.Add(v1);
			Root.Add(v2);
			Root.Add(v3);

			//Default Selected
			SelectedVm = v1;

			ValueChangedCommand = new ValueChangedCommand(this);
		}

		public ICommand ValueChangedCommand { get; set; }

		public ViewModel1? SelectedVm
		{
			get { return _selectedVm; }
			set { _selectedVm = value; this.OnPropertyChanged(); }
		}


		public ObservableCollection<ViewModel1> Root { get; set; }

		public void ValueChanged(string newValue, BaseViewModel vm)
		{
			if (vm != null)
			{
				if (vm is ViewModel1 v1)
				{
					var data = v1.FindChildren(vm.Id);
					data.Name = v1.Name;
					data.Gender = v1.Gender;
					data.Class = v1.Class;
					data.Properties.Clear();
					data.Properties.Add(new(data) { Title = nameof(data.Name), Value = data.Name });
					data.Properties.Add(new(data) { Title = nameof(data.Gender), Value = data.Gender });
					data.Properties.Add(new(data) { Title = nameof(data.Class), Value = data.Class });
				}

				if (vm is ViewModel2 v2)
				{
					switch (v2.Title)
					{
						case nameof(v2.Parent.Name): v2.Value = v2.Parent.Name = newValue; break;
						case nameof(v2.Parent.Gender): v2.Value = v2.Parent.Gender = newValue; break;
						case nameof(v2.Parent.Class): v2.Value = v2.Parent.Class = newValue; break;
					}
				}
			}
		}
	}
}
