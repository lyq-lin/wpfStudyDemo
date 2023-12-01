using System.Windows;
using System.Windows.Controls;

namespace WpfApp4
{
	internal class ComboDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate UcTemplate1 { get; set; }
		public DataTemplate UcTemplate2 { get; set; }
		public DataTemplate UcTemplate3 { get; set; }

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			var element = container as FrameworkElement;
			var viewModel = item as ItemViewModel;

			if (element == null || viewModel == null)
			{
				return base.SelectTemplate(item, container);
			}

			if (viewModel.Type != null)
			{
				return viewModel.Type switch
				{
					ConstTemplateType.UcTemplate1 => UcTemplate1,
					ConstTemplateType.UcTemplate2 => UcTemplate2,
					ConstTemplateType.UcTemplate3 => UcTemplate3,
					_ => base.SelectTemplate(item, container)
				};
			}

			return base.SelectTemplate(item, container);
		}
	}
}
