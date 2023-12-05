using AlmostList.Client.Models.Properties.Common;
using AlmostList.Client.Models.Properties.Media;

namespace AlmostList.Client.Models.Properties.Character
{
    public class Character
    {
        public int Id { get; set; }
        public CharacterName Name { get; set; }
        public Common.Image? Image { get; set; }
        /// <summary>
        /// can be html (bool)
        /// </summary>
        public string? Description { get; set; }
        public string? Gender { get; set; }
        public FuzzyDate? DateOfBirth { get; set; }
        public string? Age { get; set; }
        public string? BloodType { get; set; }
        public bool IsFavourite { get; set; }
        public bool isFavouriteBlocked { get; set; }
        public string? SiteUrl { get; set; }
        public MediaConnection? Media { get; set; }
        public int? Favourites { get; set; }
        public string? ModNotes { get; set; }
    }
}