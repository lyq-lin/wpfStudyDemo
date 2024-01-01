using System.Windows.Documents;

namespace AdornerDemo
{
	internal class CustomAdornerDecorator : AdornerDecorator
	{
		public CustomAdornerDecorator()
		{
			Loaded += OnAdornerLoaded;
		}

		private void OnAdornerLoaded(object sender, System.Windows.RoutedEventArgs e)
		{
			var layer = AdornerLayer.GetAdornerLayer(this);

			if (layer != null)
			{
				layer.Add(new CustomAdorner(this));
			}
		}
	}
}
