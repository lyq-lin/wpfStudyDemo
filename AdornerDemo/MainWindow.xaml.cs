using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace AdornerDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void searchText_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var layer = AdornerLayer.GetAdornerLayer(searchText);

			if (layer != null)
			{
				layer.Add(new CustomAdorner(searchText));
			}
		}

		private void searchText_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
		{
			var layer = AdornerLayer.GetAdornerLayer(searchText);

			var arrAdorner = layer.GetAdorners(searchText);

			foreach (var item in arrAdorner)
			{
				layer.Remove(item);
			}
		}
	}
}