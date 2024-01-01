using System.Globalization;
using System.Windows.Controls;

namespace ValidationDemo
{
	internal class RequireValidation : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			if (value is string searchText && !"YCode".Equals(searchText))
			{
				return new ValidationResult(false, new List<string>() { "Input Invalid!", "Please input YCode!" });
			}
			return ValidationResult.ValidResult;
		}
	}
}
