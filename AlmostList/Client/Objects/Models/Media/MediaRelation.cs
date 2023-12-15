using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace AlmostList.Client.Models.Properties.Media
{
    public enum MediaRelation
    {
        [Display(Name = "Adaptation")]
        ADAPTATION,
        [Display(Name = "Prequel")]
        PREQUEL,
        [Display(Name = "Sequel")]
        SEQUEL,
        [Display(Name = "Parent")]
        PARENT,
        [Display(Name = "Side Story")]
        SIDE_STORY,
        [Display(Name = "Character")]
        CHARACTER,
        [Display(Name = "Summary")]
        SUMMARY,
        [Display(Name = "Alternative")]
        ALTERNATIVE,
        [Display(Name = "Spin Off")]
        SPIN_OFF,
        [Display(Name = "Other")]
        OTHER,
        [Display(Name = "Source")]
        SOURCE,
        [Display(Name = "Compilation")]
        COMPILATION,
        [Display(Name = "Contains")]
        CONTAINS
    }
}