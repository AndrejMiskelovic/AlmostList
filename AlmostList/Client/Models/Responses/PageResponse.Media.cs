using AlmostList.Client.Models.Properties;

namespace AlmostList.Client.Models.Responses
{
    public record PagedMedia(PageInfo PageInfo, List<Media> Media);
	//public class PagedMedia
	//{
	//    public PageInfo PageInfo { get; set; }
	//    public List<Media> Media {  get; set; }
	//}

}
