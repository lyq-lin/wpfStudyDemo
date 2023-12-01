using System.Windows.Controls;

namespace WpfApp5
{
	/// <summary>
	/// Interaction logic for View2.xaml
	/// </summary>
	public partial class View2 : UserControl
	{
		public View2()
		{
			InitializeComponent();
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.DataContext is MainViewModel mainViewModel && sender is TextBox tb)
			{
				mainViewModel.ValueChangedCommand?.Execute(tb);
			}
		}
	}
}
