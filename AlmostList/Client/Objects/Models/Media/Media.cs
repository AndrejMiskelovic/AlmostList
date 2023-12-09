using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.AiringSchedule;
using AlmostList.Client.Models.Properties.Character;
using AlmostList.Client.Models.Properties.Common;
using AlmostList.Client.Models.Properties.Media.MediaTrend;
using AlmostList.Client.Models.Properties.Recommendation;
using AlmostList.Client.Models.Properties.Staff;
using AlmostList.Client.Models.Properties.Studio;
using AlmostList.Client.Objects.Models.Review;

namespace AlmostList.Client.Models.Properties.Media
{
    public class Media
    {
        public int Id { get; set; }
        public MediaTitle? Title { get; set; }
        public MediaType? Type { get; set; }
        public MediaFormat? Format { get; set; }
        public MediaStatus? Status { get; set; }
        public string? Description { get; set; }
        public FuzzyDate? StartDate { get; set; }
        public FuzzyDate? EndDate { get; set; }
        public MediaSeason? Season { get; set; }
        public int? SeasonYear { get; set; }
        public int? SeasonInt { get; set; }
        public int? Episodes { get; set; }
        public int? Duration { get; set; }
        public int? Chapters { get; set; }
        public int? Volumes { get; set; }
        public CountryCode? CountryCode { get; set; }
        public bool? IsLicensed { get; set; }
        public MediaSource? Source { get; set; }
        public string? Hashtah { get; set; }
        public MediaTrailer? Trailer { get; set; }
        public int? UpdatedAt { get; set; }
        public MediaCoverImage? CoverImage { get; set; }
        public string? BannerImage { get; set; }
        public List<string>? Genres { get; set; }
        public List<string>? Synonyms { get; set; }
        public int? AverageScore { get; set; }
        public int? MeanScore { get; set; }
        public int? Popularity { get; set; }
        public bool IsLocked { get; set; }
        public int? Trending { get; set; }
        public int? Favourites { get; set; }
        public List<MediaTag>? Tags { get; set; }
        public Connection<MediaEdge, Media>? Relations { get; set; }
        public Connection<CharacterEdge, Character.Character>? Characters { get; set; }
        public Connection<StaffEdge, Staff.Staff>? Staff { get; set; }
        public Connection<StudioEdge, Studio.Studio>? Studios { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsFavouriteBlocked { get; set; }
        public bool IsAdult { get; set; }
        public AiringSchedule.AiringSchedule? NextAiringEpisode { get; set; }
        public Connection<AiringScheduleEdge, AiringSchedule.AiringSchedule>? AiringSchedule { get; set; }
        public Connection<MediaTrendEdge, MediaTrend.MediaTrend>? Trends { get; set; }
        public List<MediaExternalLink>? ExternalLinks { get; set; }
        public List<MediaStreamingEpisode>? StreamingEpisodes { get; set; }
        public List<MediaRank>? Rankings { get; set; }
        public MediaList? MediaListEntry { get; set; }
        public Connection<ReviewEdge, Review>? Reviews { get; set; }
        public Connection<RecommendationEdge, Recommendation.Recommendation>? Recommendations { get; set; }
        public MediaStats? Stats { get; set; }
        public bool? AutoCreateForumThread { get; set; }
        public bool? IsRecommendationBlocked { get; set; }
        public bool? IsReviewBlocked { get; set; }
        public string? ModNotes { get; set; }
    }
}