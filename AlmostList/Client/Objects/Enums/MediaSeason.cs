using System.ComponentModel.DataAnnotations;

namespace AlmostList.Client.Models
{
    public enum MediaSeason
    {
		[Display(Name = "Winter")]
		WINTER,
		[Display(Name = "Spring")]
        SPRING,
		[Display(Name = "Summer")]
        SUMMER,
		[Display(Name = "Fall")]
        FALL
    }
}
