using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AlmostList.Client.Models.Enums
{
    public enum MediaStatus
    {
		[Display(Name = "Finished")]
		FINISHED,
		[Display(Name = "Releasing")]
        RELEASING,
		[Display(Name = "Not Yet Released")]
        NOT_YET_RELEASED,
		[Display(Name = "Cancelled")]
        CANCELLED,
		[Display(Name = "Hiatus")]
        HIATUS
    }
}

