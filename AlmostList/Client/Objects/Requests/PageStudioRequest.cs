using AlmostList.Client.Models.Enums;

namespace AlmostList.Client.Objects.Requests
{
    public class PageStudioRequest
    {
        public int? Page { get; set; } = 1;
        public string? Search { get; set; }
        public List<StudioSort>? Sort { get; set; } = new List<StudioSort>() { StudioSort.FAVOURITES_DESC };

    }
}
