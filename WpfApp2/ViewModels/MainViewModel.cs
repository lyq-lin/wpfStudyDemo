namespace WpfApp2
{
	public class MainViewModel : BaseViewModel
	{
		private string _tips;

		public string Tips
		{
			get { return _tips; }
			set { _tips = value; RaisePropertyChanged(); }
		}

		public MainViewModel()
		{
			Tips = "请输入内容";


			Tips = "数据源对象";
		}
	}
}
