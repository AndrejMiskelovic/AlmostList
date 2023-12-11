using System.ComponentModel.DataAnnotations;

namespace AlmostList.Client.Models.Enums
{
    public enum CharacterRole
    {
		[Display(Name = "Main")]
		MAIN,
		[Display(Name = "Supporting")]
        SUPPORTING,
		[Display(Name = "Background")]
        BACKGROUND
    }
}