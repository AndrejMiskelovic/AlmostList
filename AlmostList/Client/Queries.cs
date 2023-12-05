using System.ComponentModel;

namespace AlmostList.Client
{
    public class Queries
    {
        public const string Media = @"
query ($id:Int, $statusVersion:Int, $sourceVersion:Int, $relationTypeVersion: Int) {
    Media(id:$id) {
        id
        idMal
        title {
            romaji
            english
            native
            userPreferred
        }
        type
        format
        status(version: $statusVersion)
        description(asHtml: false)
        startDate {
            year
            month
            day
        }
        endDate {
            year
            month
            day
        }
        season
        seasonYear
        episodes
        duration
        chapters
        volumes
        countryOfOrigin
        isLicensed
        source(version: $sourceVersion)
        trailer {
            id
            site
            thumbnail
        }
        coverImage {
            extraLarge
            large
            medium
        }
        bannerImage
        genres
        synonyms
        averageScore
        meanScore
        popularity
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
        relations {
            edges {
                node {
                    id
                    title {
                        romaji
                        english
                        native
                        userPreferred
                    }
                    type
                    format
                    coverImage {
                        extraLarge
                        large
                        medium
                    }
                    countryOfOrigin
                }
                relationType(version: $relationTypeVersion)
            }
        }
        characters(role: MAIN, sort: [ID]) {
            nodes {
                id
                name {
                    first
                    middle
                    last
                    full
                    native
                    alternative
                    alternativeSpoiler
                    userPreferred
                }
                image {
                    large
                    medium
                }
            }
        }
        staff(sort:[RELEVANCE, ID]) {
            edges {
                node {
                    id
                    name {
                        first
                        middle
                        last
                        full
                        native
                        alternative
                        userPreferred
                    }
                    image {
                        large
                        medium
                    }
                }
                id
                role
            }
        }
        studios {
            edges {
                node {
                    id
                    name
                    isAnimationStudio
                }
                id
                isMain
            }
        }
        isFavourite
        isAdult
        nextAiringEpisode {
            id
            airingAt
            timeUntilAiring
            episode
        }
        externalLinks {
            id
            url
            site
            siteId
            type
            language
            color
            icon
        }
        rankings {
            id
            rank
            type
            format
            year
            season
            allTime
            context
        }
        recommendations(sort:[RATING_DESC]) {
            nodes {
                id
              	rating
              	userRating
              	mediaRecommendation {
                  	id
                  	title {
                      	romaji
                      	english
                      	native
                      	userPreferred
                    }
                    countryOfOrigin
                    type
                  	format
                  	status(version: $statusVersion)
                  	startDate {
                        year
                        month
                        day
                    }
                  	episodes
                  	chapters
                  	coverImage {
                      	extraLarge
                      	large
                      	medium
                    }
                  	averageScore
                  	favourites
                }
            }
        }
        stats {
            scoreDistribution {
                score
                amount
            }
            statusDistribution {
                status
                amount
            }
        }
        siteUrl
    }
}";

        public const string MediaListEntry = @"
query ($userId:Int, $mediaId:Int) {
    MediaList(userId:$userId, mediaId:$mediaId) {
        id
        userId
        mediaId
        status
        score
        progress
        progressVolumes
        repeat
        priority
        private
        notes
        hiddenFromStatusLists
        customLists
        advancedScores
        startedAt {
            year
            month
            day
        }
        completedAt {
            year
            month
            day
        }
        updatedAt
        createdAt
    }
}";

        public const string PageMedia = @"
query (  $page:Int,
  $statusVersion:Int,
  $sourceVersion: Int,
  $search:String,
  $type:MediaType,
  $sort: [MediaSort],
  $formatIn: [MediaFormat],
  $statusIn: [MediaStatus],
  $sourceIn: [MediaSource],
  $countryOfOrigin: CountryCode,
  $season: MediaSeason,
  $seasonYear: Int,
  $startDateGreater: FuzzyDateInt,
  $startDateLesser: FuzzyDateInt,
  $isAdult: Boolean,
  $onList: Boolean,
  $genreIn: [String],
  $genreNotIn: [String],
  $minimumTagRank: Int,
  $tagIn: [String],
  $tagNotIn: [String],
  $licensedByIdIn: [Int],
  $episodesGreater: Int,
  $episodesLesser: Int,
  $durationGreater: Int,
  $durationLesser: Int,
  $chaptersGreater: Int,
  $chaptersLesser: Int,
  $volumesGreater: Int,
  $volumesLesser: Int,
  $averageScoreGreater: Int,
  $averageScoreLesser: Int,
  $popularityGreater: Int,
  $popularityLesser: Int,
  $isLicensed: Boolean
) {
  Page(page:$page) {
    pageInfo {
      total
      perPage
      currentPage
      lastPage
      hasNextPage
    }
    media(
      search:$search,
      type:$type,
      sort:$sort,
      format_in: $formatIn,
      status_in: $statusIn,
      source_in: $sourceIn,
      countryOfOrigin: $countryOfOrigin,
      season: $season,
      seasonYear: $seasonYear,
      startDate_greater: $startDateGreater,
      startDate_lesser: $startDateLesser,
      isAdult: $isAdult,
      onList: $onList,
      genre_in: $genreIn,
      genre_not_in: $genreNotIn,
      minimumTagRank: $minimumTagRank,
      tag_in: $tagIn,
      tag_not_in: $tagNotIn,
      licensedById_in: $licensedByIdIn,
      episodes_greater: $episodesGreater,
      episodes_lesser: $episodesLesser,
      duration_greater: $durationGreater,
      duration_lesser: $durationLesser,
      chapters_greater: $chaptersGreater,
      chapters_lesser: $chaptersLesser,
      volumes_greater: $volumesGreater,
      volumes_lesser: $volumesLesser,
      averageScore_greater: $averageScoreGreater,
      averageScore_lesser: $averageScoreLesser,
      popularity_greater: $popularityGreater,
      popularity_lesser: $popularityLesser,
      isLicensed: $isLicensed
    ) {
      id
      idMal
      title {
        romaji
        english
        native
        userPreferred
      }
      countryOfOrigin
      type
      format
      status(version:$statusVersion)
      description(asHtml: false)
      episodes
      chapters
      volumes
      startDate {
        year
        month
        day
      }
      genres
      studios(isMain:true) {
        edges {
          node {
            name
          }
        }
      }
      staff {
        edges {
          node {
            name {
              first
              middle
              last
              full
              native
              alternative
              userPreferred
            }
          }
          role
        }
      }
      source(version:$sourceVersion)
      coverImage {
        extraLarge
        large
        medium
      }
      bannerImage
      averageScore
      meanScore
      popularity
      trending
      favourites
      mediaListEntry {
        status
      }
      stats {
          scoreDistribution {
              score
              amount
          }
          statusDistribution {
              status
              amount
          }
      }
    }
  }
}
";

		public const string UserMain = @"
query (	$id: Int, $name: String) {
  User(id: $id, name: $name) {
    id
    name
    about(asHtml: false)
    avatar {
      large
      medium
    }
    bannerImage
    isFollowing
    isFollower
    isBlocked
    options {
      titleLanguage
      displayAdultContent
      airingNotifications
      timezone
      activityMergeTime
      staffNameLanguage
      restrictMessagesToFollowing
      disabledListActivity {
        disabled
        type
      }
    }
    favourites {
      anime {
        nodes {
          id
          title {
            romaji
            english
            native
            userPreferred
          }
          coverImage {
            extraLarge
            large
            medium
          }
          siteUrl
        }
      }
      manga {
        nodes {
          id
          title {
            romaji
            english
            native
            userPreferred
          }
          coverImage {
            extraLarge
            large
            medium
          }
          siteUrl
        }
      }
      characters {
        nodes {
          id
          name {
            first
            middle
            last
            full
            native
            alternative
            alternativeSpoiler
            userPreferred
          }
          image {
            large
            medium
          }
          siteUrl
        }
      }
      staff {
        nodes {
          id
          name {
            first
            middle
            last
            full
            native
            alternative
            userPreferred
          }
          languageV2
          image {
            large
            medium
          }
          siteUrl
        }
      }
      studios {
        nodes {
          id
          name
          siteUrl
        }
      }
    }
    statistics {
      anime {
        count
        meanScore
        standardDeviation
        minutesWatched
        episodesWatched
        genrePreview: genres(limit: 10, sort: COUNT_DESC) {
          genre
          count
        }
      }
      manga {
        count
        meanScore
        standardDeviation
        minutesWatched
        episodesWatched
        genrePreview: genres(limit: 10, sort: COUNT_DESC) {
          genre
          count
        }
      }
    }
    unreadNotificationCount
    donatorTier
    donatorBadge
    moderatorRoles
    siteUrl
    createdAt
  }
}";

		public const string ExternalLisks = @"
query ($mediaType: ExternalLinkMediaType, $type: ExternalLinkType) {
  ExternalLinkSourceCollection(mediaType: $type, type: INFO) {
    id
    url
    site
    type
    language
    color
    icon
  }
}";

	}
}
