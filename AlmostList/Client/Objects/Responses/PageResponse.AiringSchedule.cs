using AlmostList.Client.Models.Properties;
using AlmostList.Client.Models.Properties.AiringSchedule;

namespace AlmostList.Client.Objects.Responses
{
	public record PagedAirSchedule(PageInfo PageInfo, List<AiringSchedule> AiringSchedules);
}
