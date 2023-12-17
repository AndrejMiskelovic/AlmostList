using Newtonsoft.Json;

namespace AlmostList.Client.Models.Properties.User
{
	public class UserStatistics
	{
		public int Count { get; set; }
		public double MeanScore { get; set; }
		public double StandardDeviation { get; set; }
		public int MinutesWatched { get; set; }
		public int EpisodesWatched { get; set; }
		public int ChaptersRead { get; set; }
		public int VolumesRead { get; set; }
	}
}