using AlmostList.Client.Models.Properties.User;

namespace AlmostList.Client.Models.Responses
{
    public class UserMainResponse
    {
        public User? User { get; set; }
        public Favourites? Favourites { get; set; }
    }
}