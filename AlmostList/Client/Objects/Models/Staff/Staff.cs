using AlmostList.Client.Models.Properties.Character;
using AlmostList.Client.Models.Properties.Common;
using AlmostList.Client.Models.Properties.Media;
using AlmostList.Client.Models.Properties.User;
using System.Text.Json.Serialization;

namespace AlmostList.Client.Models.Properties.Staff
{
    public class Staff
    {
        public int Id { get; set; }
        public Name? Name { get; set; }
        public string? languageV2 { get; set; }
        public Common.Image? Image { get; set; }
        public string? Description { get; set; }
        public List<string>? PrimaryOccupations { get; set; }
        public string? Gender { get; set; }
        public FuzzyDate? DateOfBirth { get; set; }
        public FuzzyDate? DateOfDeath { get; set; }
        public int? Age { get; set; }
        public List<int>? YearsActive { get; set; }
        public string? HomeTown { get; set; }
        public string? BloodType { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsFavouriteBlocked { get; set; }
        public bool SiteUrl { get; set; }
        public Connection<MediaEdge, Media.Media>? StaffMedia { get; set; }
        public Connection<CharacterEdge, Character.Character>? Characters { get; set; }
        public Connection<MediaEdge, Media.Media>? CharacterMedia { get; set; }
        [JsonPropertyName("Staff")]
        public Staff? StaffReferal { get; set; }
        public User.User? Submitter { get; set; }
        public int? SubmissionStatus { get; set; }
        public string? SubmissionNotes { get; set; }
        public int? Favourites { get; set; }
        public string? ModNotes { get; set; }
    }
}