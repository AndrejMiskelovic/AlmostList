using AlmostList.Client.Models.Properties;
using AlmostList.Client.Models.Properties.Media;
using AlmostList.Client.Models.Properties.Staff;
using AlmostList.Client.Models.Properties.Studio;

namespace AlmostList.Client.Models.Responses
{
    public record PagedStudio(PageInfo PageInfo, List<Studio> Studio);
}
