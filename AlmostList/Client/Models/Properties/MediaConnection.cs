using AlmostList.Client.Models.Properties;

namespace AlmostList.Client.Models
{
	public class MediaConnection
	{
		public List<MediaEdge>? Edges { get; set; }
		public List<Media>? Nodes { get; set; }
		public PageInfo? PageInfo { get; set; }
	}
}