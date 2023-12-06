using AlmostList.Client.Models.Enums;
using Google.Android.Material.Color.Utilities;
using static Android.InputMethodServices.Keyboard;

namespace AlmostList.Client.Models.Properties.User
{
	public class MediaListOptions
    {
		public ScoreFormat ScoreFormat { get; set; }
		public string? RowOrder { get; set; }
		public MediaListTypeOptions? AnimeList { get; set; }
		public MediaListTypeOptions? MangaList { get; set; }
	}
}