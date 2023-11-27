namespace AlmostList.Client.Anime
{
    public class Queries
    {
        public const string MediaQuery = @"
query ($id: Int) {
    Media (id: $id, type: ANIME) {
        id
        title {
            english
            romaji
            userPreferred
        }
        type
        format
        status
        description
        startDate{
            year
            month
            day
        }
        endDate{
            year
            month
            day
        }
        season
        seasonYear
        seasonInt
        episodes
        duration
        chapters
        volumes
        source
        coverImage { 
            extraLarge 
            large 
            medium 
            color 
        }
        bannerImage 
        genres
        synonyms
        averageScore
        meanScore
        popularity
        isLocked 
        trending 
        favourites 
        tags { 
            id 
            name 
            description 
            category 
            rank 
            isGeneralSpoiler 
            isMediaSpoiler 
            isAdult 
        } 
        nextAiringEpisode {
            id 
            airingAt 
            timeUntilAiring 
            episode     
            mediaId             
        }
    }
}";
        public const string ListMedia = @"
query($page:Int) {
    Page(page: $page, perPage:20) {
        pageInfo {
            total 
            perPage 
            currentPage 
            lastPage
            hasNextPage
        }
        media {
            id
            title {
                userPreferred
            }
            coverImage { 
                extraLarge 
                large 
                medium 
                color 
            }
        }
    }
}
";
    }
}
