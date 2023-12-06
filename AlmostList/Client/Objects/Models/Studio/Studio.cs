using AlmostList.Client.Models.Properties.Common;
using AlmostList.Client.Models.Properties.Media;

namespace AlmostList.Client.Models.Properties.Studio
{
    public class Studio
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public bool? IsAnimationStudio { get; set; }
        public Connection<MediaEdge, Media.Media>? Media { get; set; }
        public string? SiteUrl { get; set; }
        public bool? IsFavourite { get; set; }
        public int? Favourites { get; set; }
    }
}
