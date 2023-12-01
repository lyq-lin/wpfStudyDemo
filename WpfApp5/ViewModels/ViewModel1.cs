using System;
using System.Collections.ObjectModel;

namespace WpfApp5
{
	class ViewModel1 : BaseViewModel
	{
		private string _name;
		private string _gender;
		private string _class;
		private ObservableCollection<ViewModel2> _properties = new();

		public ViewModel1()
		{
			base.Children.Add(this);
		}

		public ObservableCollection<ViewModel2> Properties
		{
			get { return _properties; }
			set { _properties = value; }
		}


		public string Name
		{
			get { return _name; }
			set { _name = value; this.OnPropertyChanged(); }
		}


		public string Gender
		{
			get { return _gender; }
			set { _gender = value; this.OnPropertyChanged(); }
		}

		public string Class
		{
			get { return _class; }
			set { _class = value; this.OnPropertyChanged(); }
		}

		public ViewModel1 FindChildren(Guid id)
		{
			if (this.Id == id)
			{
				return this;
			}

			foreach (var child in this.GetChildren<ViewModel1>())
			{
				var r = child.FindChildren(id);
				if (r != null)
				{
					return r;
				}
			}

			return null;
		}
	}
}
