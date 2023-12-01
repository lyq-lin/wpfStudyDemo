namespace WpfApp4
{
	internal class ItemViewModel : BaseViewModel
	{
		private string _type;

		public string Type
		{
			get { return _type; }
			set { _type = value; RaisePropertyChanged(); }
		}

	}
}
