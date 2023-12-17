using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.Common;
using System.Reflection;

namespace AlmostList.Client.Models.Properties.User
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        /// <summary>
        /// can be retriewed as html (check query)
        /// </summary>
        public string About { get; set; } = null!;
        public Common.Image Avatar { get; set; } = null!;
        public string BannerImage { get; set; } = null!;
        public bool IsFollowing { get; set; }
        public bool IsFollower { get; set; }
        public bool IsBlocked { get; set; }
        public string? Bans { get; set; }
        public UserOptions? Options { get; set; }
        public MediaListOptions? MediaListOptions { get; set; }
        public Favourites? Favourites  { get; set; }
        public UserStatisticTypes? Statistics { get; set; }
        public int? UnreadNotificationCount { get; set; }
        public string? SiteUrl { get; set; }
        public int? DonatorTier { get; set; }
        public string? DonatorBadge { get; set; }
        public List<ModRole>? ModeratorRoles { get; set; }
        public int? CreatedAt { get; set; }
        public int? UpdatedAt { get; set; }
        public List<UserPreviousName>? PreviousNames { get; set; }
    }
}