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
	}
}
