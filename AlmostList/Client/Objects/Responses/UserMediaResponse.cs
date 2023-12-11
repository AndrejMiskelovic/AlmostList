using AlmostList.Client.Models.Properties.User;
using AlmostList.Client.Objects.Models.Media;

namespace AlmostList.Client.Models.Responses
{
    public class UserMediaResponse
    {
        public MediaListCollection? MediaListCollection { get; set; }
        public User? User { get; set; }
    }
}