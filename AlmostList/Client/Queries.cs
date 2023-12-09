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
        nextAiringEpisode{
          airingAt,
          episode
        }
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

		public const string MediaWithMediaListEntry = @"
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
        nextAiringEpisode{
          airingAt,
          episode
        }
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
                    isAdult
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
        mediaListEntry {
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
      episodes
      chapters
      volumes
      startDate {
        year
        month
        day
      }
      genres
      source(version:$sourceVersion)
      coverImage {
        extraLarge
        large
        medium
      }
      averageScore
      meanScore
      popularity
      trending
      favourites
      seasonYear
	  seasonInt
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

		public const string UserMedia = @"
query ($userId: Int, $userName: String, $type: MediaType) {
  MediaListCollection(userId: $userId, userName: $userName, type: $type) {
    lists {
      name
      isCustomList
      isCompletedList: isSplitCompletedList
      entries {
  id
  mediaId
  status
  score
  progress
  progressVolumes
  repeat
  priority
  private
  hiddenFromStatusLists
  customLists
  advancedScores
  notes
  updatedAt
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
  media {
    id
    title {
      userPreferred
      romaji
      english
      native
    }
    coverImage {
      extraLarge
      large
    }
    type
    format
    status(version: 2)
    episodes
    volumes
    chapters
    averageScore
    popularity
    isAdult
    countryOfOrigin
    genres
    bannerImage
    startDate {
      year
      month
      day
    }
  }
}
    }
    user {
      id
      name
      avatar {
        large
      }
      mediaListOptions {
        scoreFormat
        rowOrder
        animeList {
          sectionOrder
          customLists
          splitCompletedSectionByFormat
          theme
        }
        mangaList {
          sectionOrder
          customLists
          splitCompletedSectionByFormat
          theme
        }
      }
    }
  }
}
";

		public const string ExternalLisks = @"
query ($mediaType: ExternalLinkMediaType, $type: ExternalLinkType) {
  ExternalLinkSourceCollection(mediaType: $mediaType, type: $type) {
    id
    url
    site
    type
    language
    color
    icon
  }
}";

        public const string GenresAndTagsCollection = @"
query {
  genres: GenreCollection
  tags: MediaTagCollection {
    name
    description
    category
    isAdult
  }
}";

		public const string PageStudioWithListMedia = @"
query ($page:Int, $search:String, $sort: [StudioSort] = [FAVOURITES_DESC]) {
  Page(page:$page) {
    pageInfo {
      total
      perPage
      currentPage
      lastPage
      hasNextPage
    }
    studios(search:$search, sort: $sort) {
      id
      name
      favourites
      media(sort:[POPULARITY_DESC] perPage:3) {
        nodes {
          id
          coverImage {
            large
            color
          }
        }
      }
    }
  }
}";

		public const string StudioWithListMedia = @"
query ($id: Int, $page: Int, $sort: [MediaSort], $onList: Boolean) {
  Studio(id: $id) {
    id
    name
    isAnimationStudio
    favourites
    isFavourite
    media(page: $page, sort: $sort, onList: $onList) {
      pageInfo {
        total
        perPage
        currentPage
        lastPage
        hasNextPage
      }
      edges {
        isMainStudio
        node {
          id
          title {
            userPreferred
          }
          coverImage {
            large
            color
          }
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
          bannerImage       
          type
          format
          status(version: 2)
          isAdult
          averageScore
          popularity
        }
      }
    }
  }
}
";

		public const string PageCharacter = @"
query ($page: Int, $id: Int, $search: String, $isBirthday: Boolean, $sort: [CharacterSort] = [FAVOURITES_DESC]) {
  Page(page: $page) {
    pageInfo {
      total
      perPage
      currentPage
      lastPage
      hasNextPage
    }
    characters(id: $id, search: $search, isBirthday: $isBirthday, sort: $sort) {
      id
      favourites
      name {
        userPreferred
      }
      image {
        large
      }
    }
  }
}
";

		public const string PageStaff = @"
query ($page: Int, $id: Int, $search: String, $isBirthday: Boolean, $sort: [CharacterSort] = [FAVOURITES_DESC]) {
  Page(page: $page) {
    pageInfo {
      total
      perPage
      currentPage
      lastPage
      hasNextPage
    }
    characters(id: $id, search: $search, isBirthday: $isBirthday, sort: $sort) {
      id
      favourites
      name {
        userPreferred
      }
      image {
        large
      }
    }
  }
}
";

        public const string PageAiringSchedule = @"
query($page: Int,
  $airingAtGreater: Int,
  $airingAtLesser: Int
) {
  Page(page: $page) {
    pageInfo {
      total
      perPage
      currentPage
      lastPage
      hasNextPage
    }
    airingSchedules(
      airingAt_greater: $airingAtGreater,
      airingAt_lesser: $airingAtLesser,
      sort: [TIME]
    ) {
      id
      airingAt
      timeUntilAiring
      episode
      media {
        id
        title {
          romaji
          english
          native
          userPreferred
        }
        countryOfOrigin
        season
        seasonYear
        bannerImage
        isAdult
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
        mediaListEntry {
          status
        }
      }
    }
  }
}";

        public const string Viewer = @"
query {
  Viewer {
    id
    name
    avatar {
      large
      medium
    }
    options {
      titleLanguage
      displayAdultContent
      airingNotifications
      notificationOptions {
        type
        enabled
      }
      timezone
      activityMergeTime
      staffNameLanguage
      restrictMessagesToFollowing
      disabledListActivity {
        disabled
        type
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

        public const string DeleteMediaEntry = @"
mutation ($id: Int) {
    DeleteMediaListEntry(id: $id) {
        deleted
    }
}";

        public const string UpdateUser = @"
mutation ($titleLanguage:UserTitleLanguage,
  $displayAdultContent:Boolean,
  $airingNotifications:Boolean,
  $scoreFormat:ScoreFormat,
  $rowOrder:String,
  $notificationOptions:[NotificationOptionInput],
  $timezone:String,
  $activityMergeTime:Int,
  $animeListOptions:MediaListOptionsInput,
  $mangaListOptions:MediaListOptionsInput,
  $staffNameLanguage:UserStaffNameLanguage,
  $restrictMessagesToFollowing:Boolean,
  $disabledListActivity:[ListActivityOptionInput]
) {
  UpdateUser(
    titleLanguage:$titleLanguage,
    displayAdultContent:$displayAdultContent,
    airingNotifications:$airingNotifications,
    scoreFormat:$scoreFormat,
    rowOrder:$rowOrder,
    notificationOptions:$notificationOptions,
    timezone:$timezone,
    activityMergeTime:$activityMergeTime,
    animeListOptions:$animeListOptions,
    mangaListOptions:$mangaListOptions,
    staffNameLanguage:$staffNameLanguage,
    restrictMessagesToFollowing:$restrictMessagesToFollowing,
    disabledListActivity:$disabledListActivity
  ) {
    id
    name
    about(asHtml: false)
    avatar {
      large
      medium
    }
    bannerImage
    options {
      titleLanguage
      displayAdultContent
      airingNotifications
      notificationOptions {
        type
        enabled
      }
      timezone
      activityMergeTime
      staffNameLanguage
      restrictMessagesToFollowing
      disabledListActivity {
        disabled
        type
      }
    }
    mediaListOptions {
      scoreFormat
      rowOrder
      animeList {
        sectionOrder
        splitCompletedSectionByFormat
        customLists
        advancedScoring
        advancedScoringEnabled
      }
      mangaList {
        sectionOrder
        splitCompletedSectionByFormat
        customLists
        advancedScoring
        advancedScoringEnabled
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
    }
}
