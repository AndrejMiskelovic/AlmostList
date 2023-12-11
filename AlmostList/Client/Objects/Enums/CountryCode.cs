using AlmostList.Client.Models.Properties.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AlmostList.Client.Models.Enums
{
    public enum CountryCode
	{
		[Display(Name = "Japan")] JP,
        [Display(Name = "South Korea")] KR,
        [Display(Name = "China")] CN,
        [Display(Name = "Taiwan")] TW,
    }
}
