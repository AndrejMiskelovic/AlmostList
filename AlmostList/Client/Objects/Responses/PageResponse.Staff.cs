using AlmostList.Client.Models.Properties;
using AlmostList.Client.Models.Properties.Media;
using AlmostList.Client.Models.Properties.Staff;

namespace AlmostList.Client.Models.Responses
{
    public record PagedStaff(PageInfo PageInfo, List<Staff> Staff);
}
