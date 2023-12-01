namespace WpfApp5
{
	class ViewModel2 : BaseViewModel
	{
		private string _title;

		private string _value;

		public ViewModel2(ViewModel1 viewModel1)
		{
			Parent = viewModel1;
			base.Children.Add(this);
		}

		public ViewModel1 Parent { get; init; }

		public string Value
		{
			get { return _value; }
			set { _value = value; this.OnPropertyChanged(); }
		}

		public string Title
		{
			get { return _title; }
			set { _title = value; this.OnPropertyChanged(); }
		}

	}
}
