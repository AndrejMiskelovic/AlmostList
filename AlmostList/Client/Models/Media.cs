namespace AlmostList.Client.Models
{
    public class MediaResponse
    {
        public Media Media { get; set; }
    }

    public class Media
    {
        public int Id { get; set; }
        public MediaTitle Title { get; set; }
        public MediaType Type { get; set; }
        public MediaFormat Format { get; set; }
        public MediaStatus Status { get; set; }
        public string Description { get; set; }
        public FuzzyDate StartDate { get; set; }
        public FuzzyDate EndDate { get; set; }
        public MediaSeason Season { get; set; }
        public int? SeasonYear { get; set; }
        public int? SeasonInt { get; set; }
        public int? Episodes { get; set; }
        public int? Duration { get; set; }
        public int? Chapters { get; set; }
        public int? Volumes { get; set; }
        public MediaSource Source { get; set; }
        //public int UpdatedAt { get; set; }
        public MediaCoverImage CoverImage { get; set; }
        public string BannerImage { get; set; }
        public string[] Genres { get; set; }
        public string[] Synonyms { get; set; }
        public int? AverageScore { get; set; }
        public int? MeanScore { get; set; }
        public int? Popularity { get; set; }
        public bool IsLocked { get; set; }
        public int? Trending { get; set; }
        public int? Favourites { get; set; }
        public MediaTag[] Tags { get; set; }
        //public MediaConnection Relations { get; set; }
        public AiringSchedule NextAiringEpisode { get; set; }
        public enum MediaSource
        {
            ORIGINAL,
            MANGA,
            LIGHT_NOVEL,
            VISUAL_NOVEL,
            VIDEO_GAME,
            OTHER,
            NOVEL,
            DOUJINSHI,
            ANIME,
            WEB_NOVEL,
            LIVE_ACTION,
            GAME,
            COMIC,
            MULTIMEDIA_PROJECT,
            PICTURE_BOOK
        }
        public enum MediaType
        {
            ANIME,
            MANGA
        }

        public enum MediaFormat
        {
            TV,
            TV_SHORT,
            MOVIE,
            SPECIAL,
            OVA,
            ONA,
            MUSIC,
            MANGA,
            NOVEL,
            ONE_SHOT

        }

        public enum MediaStatus
        {
            FINISHED,
            RELEASING,
            NOT_YET_RELEASED,
            CANCELLED,
            HIATUS,
        }

        public class MediaTitle
        {
            public string? Romaji { get; set; }
            public string? English { get; set; }
            public string? Native { get; set; }
            public string? UserPreferred { get; set; }
        }

        public class AiringSchedule
        {
            public int? Id { get; set; }
            public int? AiringAt { get; set; }
            /// <summary>
            /// Seconds until episode starts airing
            /// </summary>
            public int? TimeUntilAiring { get; set; }
            public int? Episode { get; set; }
            public int? MediaId { get; set; }
            public Media? Media { get; set; }
        }

        public class MediaTag
        {
            public int? Id { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
            public string? Category { get; set; }
            public int? Rank { get; set; }
            public bool IsGeneralSpoiler { get; set; }
            public bool IsMediaSpoiler { get; set; }
            public bool IsAdult { get; set; }
        }

        public class MediaCoverImage
        {
            public string? ExtraLarge { get; set; }
            public string? Large { get; set; }
            public string? Medium { get; set; }
            public string? Color { get; set; }
        }

        public enum MediaSeason
        {
            WINTER,
            SPRING,
            SUMMER,
            FALL
        }

        public class FuzzyDate
        {
            public int? Year { get; set; }
            public int? Month { get; set; }
            public int? Day { get; set; }
        }
    }
}
