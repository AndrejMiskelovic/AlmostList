using AlmostList.Client.Models.Enums;
using Android.Telephony;
using Xamarin.Google.Crypto.Tink.Signature;

namespace AlmostList.Client.Models.Requests
{
	public class PageMediaRequest
	{
		public int Page { get; set; } = 1;
		public int? StatusVersion { get; set; } = 2;
		public int? SourceVersion { get; set; } = 2;
		public string? Search { get; set; }
		public MediaType? Type { get; set; }
		public List<MediaSort> Sort { get; set; } = new List<MediaSort>() { MediaSort.TRENDING_DESC };
		public List<MediaFormat>? FormatIn { get; set; }
		public List<MediaStatus>? StatusIn { get; set; }
		public List<MediaSource>? SourceIn { get; set; }
		public CountryCode? CountryOfOrigin { get; set; }
		public MediaSeason? Season { get; set; }
		public int? SeasonYear { get; set; }
		private DateOnly? _startDateGreater { get; set; }
		private DateOnly? _startDateLesser { get; set; }
		public bool? IsAdult { get; set; } = false;
		public bool? OnList { get; set; }
		public List<string>? GenreIn { get; set; }
		public List<string>? GenreNotIn { get; set; } = new List<string>() { "Ecchi" };
		public int? MinimumTagRank { get; set; }
		public List<string>? TagIn { get; set; }
		public List<string>? TagNotIn { get; set; } = new List<string>() { "Nudity" };
		public List<int>? LicensedByIdIn { get; set; }
		public int? EpisodesGreater { get; set; }
		public int? EpisodesLesser { get; set; }
		public int? DurationGreater { get; set; }
		public int? DurationLesser { get; set; }
		public int? ChaptersGreater { get; set; }
		public int? ChaptersLesser { get; set; }
		public int? VolumesGreater { get; set; }
		public int? VolumesLesser { get; set; }
		public int? AverageScoreGreater { get; set; }
		public int? AverageScoreLesser { get; set; }
		public int? PopularityGreater { get; set; }
		public int? PopularityLesser { get; set; }
		public bool? IsLicensed { get; set; }

		public string StartDateGreater
		{
			get
			{
				return _startDateGreater == null ? null : _startDateGreater.Value.ToString("yyyyMMdd");
			}
			set
			{
				if (value != null)
				{
					DateOnly.TryParse(value, out DateOnly date);
					_startDateGreater = date.AddDays(-1);
				}
			}
		}
		public string StartDateLesser
		{
			get
			{
				return _startDateLesser == null ? null : _startDateLesser.Value.ToString("yyyyMMdd");
			}
			set
			{
				if (value != null)
				{
					DateOnly.TryParse(value, out DateOnly date);
					_startDateLesser = date.AddDays(1);
				}
			}
		}

		public static PageMediaRequest Convert(PageMediaRequestViewModel pageMediaRequestViewModel)
		{
			PageMediaRequest pageMediaRequest = new PageMediaRequest();
			pageMediaRequest.Page = pageMediaRequestViewModel.Page;
			pageMediaRequest.StatusVersion = pageMediaRequestViewModel.StatusVersion;
			pageMediaRequest.SourceVersion = pageMediaRequestViewModel.SourceVersion;
			pageMediaRequest.Search = pageMediaRequestViewModel.Search;
			pageMediaRequest.Type = pageMediaRequestViewModel.Type;
			pageMediaRequest.Sort = pageMediaRequestViewModel.Sort;
			pageMediaRequest.FormatIn = pageMediaRequestViewModel.FormatIn;
			pageMediaRequest.StatusIn = pageMediaRequestViewModel.StatusIn;
			pageMediaRequest.SourceIn = pageMediaRequestViewModel.SourceIn;
			pageMediaRequest.CountryOfOrigin = pageMediaRequestViewModel.CountryOfOrigin;
			pageMediaRequest.Season = pageMediaRequestViewModel.Season;
			pageMediaRequest.SeasonYear = pageMediaRequestViewModel.SeasonYear;
			pageMediaRequest.StartDateGreater = pageMediaRequestViewModel.StartDateGreater == null ? null : pageMediaRequestViewModel.StartDateGreater.Value.ToString("dd/MM/yyyy");
			pageMediaRequest.StartDateLesser = pageMediaRequestViewModel.StartDateLesser == null ? null : pageMediaRequestViewModel.StartDateLesser.Value.ToString("dd/MM/yyyy");
			pageMediaRequest.IsAdult = pageMediaRequestViewModel.IsAdult;
			pageMediaRequest.OnList = pageMediaRequestViewModel.OnList;
			pageMediaRequest.GenreIn = pageMediaRequestViewModel.GenreIn;
			pageMediaRequest.GenreNotIn = pageMediaRequestViewModel.GenreNotIn;
			pageMediaRequest.MinimumTagRank = pageMediaRequestViewModel.MinimumTagRank;
			pageMediaRequest.TagIn = pageMediaRequestViewModel.TagIn;
			pageMediaRequest.TagNotIn = pageMediaRequestViewModel.TagNotIn;
			pageMediaRequest.LicensedByIdIn = pageMediaRequestViewModel.LicensedByIdIn;
			pageMediaRequest.EpisodesGreater = pageMediaRequestViewModel.EpisodesGreater;
			pageMediaRequest.EpisodesLesser = pageMediaRequestViewModel.EpisodesLesser;
			pageMediaRequest.DurationGreater = pageMediaRequestViewModel.DurationGreater;
			pageMediaRequest.DurationLesser = pageMediaRequestViewModel.DurationLesser;
			pageMediaRequest.ChaptersGreater = pageMediaRequestViewModel.ChaptersGreater;
			pageMediaRequest.ChaptersLesser = pageMediaRequestViewModel.ChaptersLesser;
			pageMediaRequest.VolumesGreater = pageMediaRequestViewModel.VolumesGreater;
			pageMediaRequest.VolumesLesser = pageMediaRequestViewModel.VolumesLesser;
			pageMediaRequest.AverageScoreGreater = pageMediaRequestViewModel.AverageScoreGreater;
			pageMediaRequest.AverageScoreLesser = pageMediaRequestViewModel.AverageScoreLesser;
			pageMediaRequest.PopularityGreater = pageMediaRequestViewModel.PopularityGreater;
			pageMediaRequest.PopularityLesser = pageMediaRequestViewModel.PopularityLesser;
			pageMediaRequest.IsLicensed = pageMediaRequestViewModel.IsLicensed;
			return pageMediaRequest;
		}
	}
}
