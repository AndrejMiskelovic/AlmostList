using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.Staff;

namespace AlmostList.Client.Models.Properties.Media
{
    public class MediaEdge
    {
        public Media? Node { get; set; }
        public int Id { get; set; }
        public MediaRelation RelationType { get; set; }
        public bool IsMainStudio { get; set; }
        public List<Character.Character>? CharacterRole { get; set; }
        public CharacterRole Characters { get; set; }
        public string? CharacterName { get; set; }
        public string? RoleNotes { get; set; }
        public string? DubGroup { get; set; }
        public string? StaffRole { get; set; }
        public List<Staff.Staff>? VoiceActors { get; set; }
        public List<StaffRoleType>? VoiceActorRoles { get; set; }
        public int? FavouriteOrder { get; set; }
    }
}