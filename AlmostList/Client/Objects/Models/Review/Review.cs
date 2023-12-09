using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.User;

namespace AlmostList.Client.Objects.Models.Review
{
	public class Review
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public int? MediaId { get; set; }
        public MediaType? MediaType { get; set; }
        public string? Summary { get; set; }
        public string? Body { get; set; }
        public int? Rating { get; set; }
        public int? RatingAmount { get; set; }
        public ReviewRating? UserRating { get; set; }
        public int? Score { get; set; }
        public bool? Private { get; set; }
        public string? SiteUrl { get; set; }
        public int? CreatedAt { get; set; }
        public int? UpdatedAt { get; set; }
        public User? User { get; set; }
        public Client.Models.Properties.Media.Media? Media { get; set; }
    }
}
