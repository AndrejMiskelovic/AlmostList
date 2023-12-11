using System.ComponentModel.DataAnnotations;

namespace AlmostList.Client.Models.Enums
{
    public enum MediaFormat
    {
		[Display(Name = "TV")]
		TV,
		[Display(Name = "TV Short")]
        TV_SHORT,
		[Display(Name = "Movie")]
        MOVIE,
		[Display(Name = "Specia")]
        SPECIAL,
		[Display(Name = "OVA")]
        OVA,
		[Display(Name = "ONA")]
        ONA,
		[Display(Name = "Music")]
        MUSIC,
		[Display(Name = "Manga")]
        MANGA,
		[Display(Name = "Light Novel")]
        NOVEL,
		[Display(Name = "One Shot")]
        ONE_SHOT
    }
}
