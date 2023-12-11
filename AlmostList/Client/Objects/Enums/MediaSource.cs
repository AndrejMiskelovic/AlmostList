using System.ComponentModel.DataAnnotations;

namespace AlmostList.Client.Models.Enums
{
    public enum MediaSource 
    {
		[Display(Name = "Original")]
		ORIGINAL,
		[Display(Name = "Manga")]
        MANGA,
		[Display(Name = "Light Novel")]
        LIGHT_NOVEL,
		[Display(Name = "Visual Novel")]
        VISUAL_NOVEL,
		[Display(Name = "Video Game")]
        VIDEO_GAME,
		[Display(Name = "Other")]
        OTHER,
		[Display(Name = "Novel")]
        NOVEL,
		[Display(Name = "Doujinshi")]
        DOUJINSHI,
		[Display(Name = "Anime")]
        ANIME,
		[Display(Name = "Web Novel")]
        WEB_NOVEL,
		[Display(Name = "Live Action")]
        LIVE_ACTION,
		[Display(Name = "Game")]
        GAME,
		[Display(Name = "Comic")]
        COMIC,
		[Display(Name = "Multimedia Project")]
        MULTIMEDIA_PROJECT,
		[Display(Name = "Picture Book")]
        PICTURE_BOOK
    }

}
