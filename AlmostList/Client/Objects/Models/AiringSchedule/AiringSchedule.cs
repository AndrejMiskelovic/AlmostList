using Android.Net.Wifi.Aware;
using Newtonsoft.Json.Converters;
using AlmostList.Utils;

namespace AlmostList.Client.Models.Properties.AiringSchedule
{
	public class AiringSchedule
    {
		public int? Id { get; set; }
		public int? AiringAt { get; set; }
		/// <summary>
		/// Seconds until episode starts airing
		/// </summary>
		public int? TimeUntilAiring { get; set; }
		public int? Episode { get; set; }
		public int? MediaId { get; set; }
		public Media.Media? Media { get; set; }
		
		public DateTime? GetTimeUntil()
		{
			return TimeUntilAiring == null ? null : UnixTmeConverter.ConvertFromUnixTimestamp(TimeUntilAiring.Value);
		}
		public DateTime? GetAiringAt()
		{
			return AiringAt == null ? null : UnixTmeConverter.ConvertFromUnixTimestamp(AiringAt.Value);
		}
	}
}
