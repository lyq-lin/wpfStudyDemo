using System.Windows.Controls;

namespace WpfApp5
{
	/// <summary>
	/// Interaction logic for View1.xaml
	/// </summary>
	public partial class View1 : UserControl
	{
		public View1()
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
