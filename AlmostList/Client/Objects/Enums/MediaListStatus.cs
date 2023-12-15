using System.ComponentModel.DataAnnotations;

namespace AlmostList.Client.Models.Enums
{
    public enum MediaListStatus
    {
		[Display(Name = "Watching")]
        CURRENT,
		[Display(Name = "Planning")]
        PLANNING,
		[Display(Name = "Completed")]
        COMPLETED,
		[Display(Name = "Dropped")]
        DROPPED,
		[Display(Name = "Paused")]
        PAUSED,
		[Display(Name = "Repeating")]
        REPEATING
    }
}