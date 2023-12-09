using AlmostList.Client.Models.Enums;

namespace AlmostList.Client.Objects.Requests
{
    public class StudioRequest
    {
        public int? Page { get; set; } = 1;
        public int? Id { get; set; }
        public bool? OnList{ get; set; }
        public List<MediaSort>? Sort { get; set; } = new List<MediaSort>() { MediaSort.FAVOURITES_DESC };
    }
}
