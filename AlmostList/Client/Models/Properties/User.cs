namespace AlmostList.Client.Models.Properties
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        //name: String!
        //about(asHtml: Boolean): String
        //avatar: UserAvatar
        //bannerImage: String
        //isFollowing: Boolean
        //isFollower: Boolean
        //isBlocked: Boolean
        //bans: Json
        //options: UserOptions
        //mediaListOptions: MediaListOptions
        //favourites(page: Int): Favourites
        //statistics: UserStatisticTypes
        //unreadNotificationCount: Int
        //siteUrl: String
        //donatorTier: Int
        //donatorBadge: String
        //moderatorRoles: [ModRole]
        //createdAt: Int
        //updatedAt: Int
        //previousNames: [UserPreviousName]
    }
}