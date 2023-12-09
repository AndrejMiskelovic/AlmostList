using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.Media;

namespace AlmostList.Client.Objects.Models.Media
{
    public class MediaListGroup
	{
		public List<MediaList>? Entries {  get; set; }
		public string? Name { get; set; }
		public bool? IsCustomList { get; set; }
		public bool? IsSplitCompletedList { get; set; }
		public MediaListStatus? Status { get; set; }
	}
}