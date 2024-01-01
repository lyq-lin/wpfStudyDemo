using System.Windows;

namespace ValidationDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public string SearchText { get; set; } = string.Empty;

		public MainWindow()
		{
			InitializeComponent();

			SearchText = "YCode";

			this.DataContext = this;
		}
	}
}