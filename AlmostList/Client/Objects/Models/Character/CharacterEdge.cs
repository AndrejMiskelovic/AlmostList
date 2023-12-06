using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.Staff;
using IntelliJ.Lang.Annotations;

namespace AlmostList.Client.Models.Properties.Character
{
    public class CharacterEdge
    {
		public Character? Node { get; set; }
		public int? Id { get; set; }
		public CharacterRole? Role { get; set; }
		public string? Name { get; set; }
		public List<Staff.Staff>? VoiceActors { get; set; }
		public List<StaffRoleType>? VoiceActorRoles { get; set; }
		public List<Media.Media>? Media { get; set; }
		public int? FavouriteOrder { get; set; }
	}
}