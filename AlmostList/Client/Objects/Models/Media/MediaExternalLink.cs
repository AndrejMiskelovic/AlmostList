using AlmostList.Client.Models.Enums;

namespace AlmostList.Client.Models.Properties.Media
{
    public class MediaExternalLink
    {
		public int Id { get; set; }
		public string? Url { get; set; }
		public string? Site { get; set; }
		public int? SiteId { get; set; }
		public ExternalLinkType? Type { get; set; }
		public string? Language { get; set; }
		public string? Color { get; set; }
		public string? Icon { get; set; }
		public string? Notes { get; set; }
		public bool IsDisabled { get; set; }
	}
}
