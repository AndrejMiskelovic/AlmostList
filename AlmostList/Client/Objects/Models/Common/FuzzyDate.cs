using System.Globalization;

namespace AlmostList.Client.Models.Properties.Common
{
    public class FuzzyDate
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
		public string TryParseToDateTime(DateTimeFormatInfo? provider = null, string format = "dd MMM yyyy")
		{
			if (provider is null)
			{
				provider = CultureInfo.CurrentUICulture.DateTimeFormat;
			}

			int year = Year ?? default(int);
			int month = Month ?? default(int);
			int day = Day ?? default(int);

			if (year != 0 && month != 0 && day != 0)
			{
				return new DateTime(year, month, day).ToString(format, provider);
			}
			else
			{
				return null;
			}
		}
	}
}
