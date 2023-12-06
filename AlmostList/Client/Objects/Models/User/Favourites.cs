using AlmostList.Client.Models.Properties.Character;
using AlmostList.Client.Models.Properties.Common;
using AlmostList.Client.Models.Properties.Media;
using AlmostList.Client.Models.Properties.Staff;
using AlmostList.Client.Models.Properties.Studio;

namespace AlmostList.Client.Models.Properties.User
{
    public class Favourites
	{
		public Connection<MediaEdge, Media.Media>? Anime { get; set; }
		public Connection<MediaEdge, Media.Media>? Manga { get; set; }
		public Connection<CharacterEdge, Character.Character>? Characters { get; set; }
		public Connection<StaffEdge, Staff.Staff>? Staff { get; set; }
		public Connection<StudioEdge, Studio.Studio>? Studios { get; set; }
	}
}