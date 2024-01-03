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
		[Display(Name = "TITLE_ENGLISH")]
		TITLE_ENGLISH,
		[Display(Name = "TITLE_ENGLISH_DESC")]
		TITLE_ENGLISH_DESC,
		[Display(Name = "TITLE_NATIVE")]
		TITLE_NATIVE,
		[Display(Name = "TITLE_NATIVE_DESC")]
		TITLE_NATIVE_DESC,
		[Display(Name = "TYPE")]
		TYPE,
		[Display(Name = "TYPE_DESC")]
		TYPE_DESC,
		[Display(Name = "FORMAT")]
		FORMAT,
		[Display(Name = "FORMAT_DESC")]
		FORMAT_DESC,
		[Display(Name = "START_DATE")]
		START_DATE,
		[Display(Name = "START_DATE_DESC")]
		START_DATE_DESC,
		[Display(Name = "END_DATE")]
		END_DATE,
		[Display(Name = "END_DATE_DESC")]
		END_DATE_DESC,
		[Display(Name = "SCORE")]
		SCORE,
		[Display(Name = "SCORE_DESC")]
		SCORE_DESC,
		[Display(Name = "POPULARITY")]
		POPULARITY,
		[Display(Name = "POPULARITY_DESC")]
		POPULARITY_DESC,
		[Display(Name = "TRENDING")]
		TRENDING,
		[Display(Name = "TRENDING_DESC")]
		TRENDING_DESC,
		[Display(Name = "EPISODES")]
		EPISODES,
		[Display(Name = "EPISODES_DESC")]
		EPISODES_DESC,
		[Display(Name = "DURATION")]
		DURATION,
		[Display(Name = "DURATION_DESC")]
		DURATION_DESC,
		[Display(Name = "STATUS")]
		STATUS,
		[Display(Name = "STATUS_DESC")]
		STATUS_DESC,
		[Display(Name = "CHAPTERS")]
		CHAPTERS,
		[Display(Name = "CHAPTERS_DESC")]
		CHAPTERS_DESC,
		[Display(Name = "VOLUMES")]
		VOLUMES,
		[Display(Name = "VOLUMES_DESC")]
		VOLUMES_DESC,
		[Display(Name = "UPDATED_AT")]
		UPDATED_AT,
		[Display(Name = "UPDATED_AT_DESC")]
		UPDATED_AT_DESC,
		[Display(Name = "SEARCH_MATCH")]
		SEARCH_MATCH,
		[Display(Name = "FAVOURITES")]
		FAVOURITES,
		[Display(Name = "FAVOURITES_DESC")]
		FAVOURITES_DESC
	}
}
