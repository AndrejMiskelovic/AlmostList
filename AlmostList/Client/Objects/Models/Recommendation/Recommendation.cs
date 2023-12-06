using AlmostList.Client.Models.Enums;

namespace AlmostList.Client.Models.Properties.Recommendation
{
	public class Recommendation
    {
        public int? Id { get; set; }
        public int? Rating { get; set; }
        public RecommendationRating? UserRating { get; set; }
        public Media.Media? Media { get; set; }
        public Media.Media? MediaRecommendation { get; set; }
        public User.User? User { get; set; }
    }
}
