﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfApp6
{
	class FilterConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			if (values[0] is DataSourceViewModel dataSource && values[1] is string searchText)
			{
				if (!dataSource.Name.ToLower().Contains(searchText.ToLower()))
				{
					return Visibility.Collapsed;
				}
			}

			return Visibility.Visible;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
