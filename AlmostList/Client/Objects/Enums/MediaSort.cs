using System.ComponentModel.DataAnnotations;

namespace AlmostList.Client.Models.Enums
{
    public enum MediaSort
	{
		[Display(Name = "ID")]
		ID,
		[Display(Name = "ID Descending")]
		ID_DESC,
		[Display(Name = "Title Romaji")]
		TITLE_ROMAJI,
		[Display(Name = "Title Romaji Descending")]
		TITLE_ROMAJI_DESC,
		[Display(Name = "Title English")]
		TITLE_ENGLISH,
		[Display(Name = "Title English Descending")]
		TITLE_ENGLISH_DESC,
		[Display(Name = "Title Native")]
		TITLE_NATIVE,
		[Display(Name = "Title Native Descending")]
		TITLE_NATIVE_DESC,
		[Display(Name = "Type")]
		TYPE,
		[Display(Name = "Type Descending")]
		TYPE_DESC,
		[Display(Name = "Format")]
		FORMAT,
		[Display(Name = "Format Descending")]
		FORMAT_DESC,
		[Display(Name = "Start Date")]
		START_DATE,
		[Display(Name = "Start Date Descending")]
		START_DATE_DESC,
		[Display(Name = "End Date")]
		END_DATE,
		[Display(Name = "End Date Descending")]
		END_DATE_DESC,
		[Display(Name = "Score")]
		SCORE,
		[Display(Name = "Score Descending")]
		SCORE_DESC,
		[Display(Name = "Popularity")]
		POPULARITY,
		[Display(Name = "Popularity Descending")]
		POPULARITY_DESC,
		[Display(Name = "Trending")]
		TRENDING,
		[Display(Name = "Trending Descending")]
		TRENDING_DESC,
		[Display(Name = "Episodes")]
		EPISODES,
		[Display(Name = "Episodes Descending")]
		EPISODES_DESC,
		[Display(Name = "Duration")]
		DURATION,
		[Display(Name = "Duration Descending")]
		DURATION_DESC,
		[Display(Name = "Status")]
		STATUS,
		[Display(Name = "Status Descending")]
		STATUS_DESC,
		[Display(Name = "Chapters")]
		CHAPTERS,
		[Display(Name = "Chapters Descending")]
		CHAPTERS_DESC,
		[Display(Name = "Volumes")]
		VOLUMES,
		[Display(Name = "Volumes Descending")]
		VOLUMES_DESC,
		[Display(Name = "Updated At")]
		UPDATED_AT,
		[Display(Name = "Updated At Descending")]
		UPDATED_AT_DESC,
		[Display(Name = "Search Match")]
		SEARCH_MATCH,
		[Display(Name = "Favourites")]
		FAVOURITES,
		[Display(Name = "Favourites Descending")]
		FAVOURITES_DESC
	}
}
