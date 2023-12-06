using AlmostList.Client.Models.Properties;
using AlmostList.Client.Models.Properties.Character;
using AlmostList.Client.Models.Properties.Media;

namespace AlmostList.Client.Models.Responses
{
    public record PagedCharacter(PageInfo PageInfo, List<Character> Character);
}
