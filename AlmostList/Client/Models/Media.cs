using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties;
using System.Security.Policy;

namespace AlmostList.Client.Models
{
    public class Media
    {
        public int? Id { get; set; }
        public MediaTitle? Title { get; set; }
        public MediaType Type { get; set; }
        public MediaFormat Format { get; set; }
        public MediaStatus Status { get; set; }
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
        public MediaSource Source { get; set; }
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
        public MediaConnection? Relations { get; set; }
        public AiringSchedule? NextAiringEpisode { get; set; }
        public MediaList? mediaListEntry { get; set; }
    }
}

//staff(
//sort: [StaffSort]
//page: Int
//perPage: Int
//): StaffConnection
//The staff who produced the media

//studios(sort: [StudioSort] isMain: Boolean): StudioConnection
//The companies who produced the media

//isFavourite: Boolean!
//If the media is marked as favourite by the current authenticated user

//isFavouriteBlocked: Boolean!
//If the media is blocked from being added to favourites

//isAdult: Boolean
//If the media is intended only for 18+ adult audiences

//nextAiringEpisode: AiringSchedule
//The media's next episode airing schedule

//airingSchedule(
//notYetAired: Boolean
//page: Int
//perPage: Int
//): AiringScheduleConnection
//The media's entire airing schedule

//trends(
//sort: [MediaTrendSort]
//releasing: Boolean
//page: Int
//perPage: Int
//): MediaTrendConnection
//The media's daily trend stats

//externalLinks: [MediaExternalLink]
//External links to another site related to the media

//streamingEpisodes: [MediaStreamingEpisode]
//Data and links to legal streaming episodes on external sites

//rankings: [MediaRank]
//The ranking of the media in a particular time span and format compared to other media

//mediaListEntry: MediaList
//The authenticated user's media list entry for the media

//reviews(
//limit: Int
//sort: [ReviewSort]
//page: Int
//perPage: Int
//): ReviewConnection
//User reviews of the media

//recommendations(
//sort: [RecommendationSort]
//page: Int
//perPage: Int
//): RecommendationConnection
//User recommendations for similar media

//stats: MediaStats
//siteUrl: String
//The url for the media page on the AniList website

//autoCreateForumThread: Boolean
//If the media should have forum thread automatically created for it on airing episode release

//isRecommendationBlocked: Boolean
//If the media is blocked from being recommended to/from

//isReviewBlocked: Boolean
//If the media is blocked from being reviewed

//modNotes: String
//Notes for site moderators