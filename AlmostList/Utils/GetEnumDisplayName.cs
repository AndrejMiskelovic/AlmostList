using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;

namespace AlmostList.Utils
{
	public static class GetEnumDisplayName
	{
		public static string GetDisplayName(this Enum enumValue)
		{
			if (enumValue == null)
				return null;
			return enumValue
					  .GetType()
					  .GetMember(enumValue.ToString())
					  .First()?
					  .GetCustomAttribute<DisplayAttribute>()?
					  .Name;
		}
	}
}
