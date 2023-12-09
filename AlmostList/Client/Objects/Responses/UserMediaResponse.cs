using AlmostList.Client.Models.Properties.User;
using AlmostList.Components.Pages;

namespace AlmostList.Client.Models.Responses
{
    public class UserMediaResponse
    {
        public Media? Media { get; set; }
        public Favourites? Favourites { get; set; }
    }
}