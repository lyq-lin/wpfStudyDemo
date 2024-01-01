using System.ComponentModel;

namespace ValidationDemo
{
	internal class CustomValidator : IDataErrorInfo
	{
		public string this[string columnName] => "input invalid!";

		public string Error => "input string invaild in TextBox";
	}
}
