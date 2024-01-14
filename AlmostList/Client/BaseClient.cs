using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.Media;
using AlmostList.Client.Models.Requests;
using AlmostList.Client.Models.Responses;
using AlmostList.Client.Objects.Requests;
using AlmostList.Client.Objects.Responses;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System.Net;

namespace AlmostList.Client
{
    public class BaseClient
	{
		private GraphQLHttpClient _graphQLClient = new GraphQLHttpClient("https://graphql.anilist.co", new NewtonsoftJsonSerializer());
		public ViewerResponse? CurrentUser { get; set; }

		public void SetToken(string token) 
		{
			if(!_graphQLClient.HttpClient.DefaultRequestHeaders.Contains("Authorization"))
				_graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
		}
		public void RemoveTokenAndUser()
		{
			_graphQLClient.HttpClient.DefaultRequestHeaders.Remove("Authorization");
			CurrentUser = null;
		}

		public async Task<GraphQLResponse<ViewerResponse>> GetCurrentUser()
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = Queries.Viewer,
                };

                var response = await _graphQLClient.SendQueryAsync<ViewerResponse>(request);
				CurrentUser = response.Data;
				return response;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
		public async Task<GraphQLResponse<MediaResponse>> GetMediaWithListEntry(int id)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.MediaWithMediaListEntry,
					Variables = new { id = id }
				};

				var response = await _graphQLClient.SendQueryAsync<MediaResponse>(request);
				return response;

			}
			catch (Exception ex)
			{

				throw;
			}
		}
		public async Task<GraphQLResponse<MediaResponse>> GetMedia(int id)
		{
			try
			{
                var request = new GraphQLRequest
                {
                    Query = Queries.Media,
                    Variables = new { id = id }
                };

                var response = await _graphQLClient.SendQueryAsync<MediaResponse>(request);
                return response;

            }
			catch (Exception ex)
			{

				throw;
			}
		}
		public async Task<GraphQLResponse<MediaListEntryResponse>> GetMediaListEntry(int mediaId, int userId )
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.MediaListEntry,
					Variables = new { mediaId = mediaId, userId = userId }
				};

				var response = await _graphQLClient.SendQueryAsync<MediaListEntryResponse>(request);
				return response;
			}
			catch (Exception ex)
			{

				throw;
			}

		}
		public async Task<GraphQLResponse<UserResponse>> GetUser(int? id, string? name = null)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.UserMain,
					Variables = new { id = id, name = name}
				};

				var response = await _graphQLClient.SendQueryAsync<UserResponse>(request);
				return response;
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		public async Task<GraphQLResponse<UserMediaResponse>> GetUserMedia(MediaType type, int? id, string? name = null)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.UserMedia,
					Variables = new { userId = id, userName = name, mediaType = type }
				};

				var response = await _graphQLClient.SendQueryAsync<UserMediaResponse>(request);
				return response;
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		public async Task<GraphQLResponse<MediaExternalLinkResponse>> GetExterlLinks(ExternalLinkType type, ExternalLinkMediaType mediaType)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.ExternalLisks,
					Variables = new { type = type, mediaType = mediaType}
				};

				var response = await _graphQLClient.SendQueryAsync<MediaExternalLinkResponse>(request);
				return response;
			}
			catch (Exception ex)
			{

				throw;
			}

		}
		public async Task<GraphQLResponse<GenresAndTagsResponse>> GetGenresAndTagsCollection()
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.GenresAndTagsCollection
				};

				var response = await _graphQLClient.SendQueryAsync<GenresAndTagsResponse>(request);
				return response;
			}
			catch (Exception ex)
			{

				throw;
			}

		}
		public async Task<GraphQLResponse<PageResponse<PagedAirSchedule>>> GetPageAiringSchedule(int greater, int lesser, int? page = 1)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.PageAiringSchedule,
					Variables = new {page = page, airingAtGreater = greater, airingAtLesser = lesser }
				};

				var response = await _graphQLClient.SendQueryAsync<PageResponse<PagedAirSchedule>>(request);
				return response;
			}
			catch (Exception ex)
			{

				throw;
			}

		}
		public async Task<GraphQLResponse<PageResponse<PagedMedia>>> GetPageMedia(PageMediaRequestViewModel variables)
		{
			try
			{
				PageMediaRequest pageMediaRequest = PageMediaRequest.Convert(variables);
				var request = new GraphQLRequest
				{
					Query = Queries.PageMedia,
					Variables = pageMediaRequest,
				};

				var response = await _graphQLClient.SendQueryAsync<PageResponse<PagedMedia>>(request);
				return response;
			}
			catch (Exception ex)
			{

				throw;
            }

		}
        public async Task<GraphQLResponse<PageResponse<PagedStudio>>> GetPageStudio(PageStudioRequest variables)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = Queries.PageStudioWithListMedia,
                    Variables = variables,
                };

                var response = await _graphQLClient.SendQueryAsync<PageResponse<PagedStudio>>(request);
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public async Task<GraphQLResponse<PageResponse<PagedStudio>>> GetStudio(StudioRequest variables)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = Queries.StudioWithListMedia,
                    Variables = variables,
                };

                var response = await _graphQLClient.SendQueryAsync<PageResponse<PagedStudio>>(request);
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public async Task<GraphQLResponse<PageResponse<PagedStaff>>> GetPageStaff(PageStaffRequest variables)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = Queries.PageStaff,
                    Variables = variables,
                };

                var response = await _graphQLClient.SendQueryAsync<PageResponse<PagedStaff>>(request);
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public async Task<GraphQLResponse<PageResponse<PagedCharacter>>> GetPageCharacher(PageCharacterRequest variables)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = Queries.PageCharacter,
                    Variables = variables,
                };

                var response = await _graphQLClient.SendQueryAsync<PageResponse<PagedCharacter>>(request);
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
		public async Task DeleteMediaEntry(int id)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.DeleteMediaEntry,
					Variables = new { id = id}
				};

				var response = await _graphQLClient.SendMutationAsync<Task>(request);
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		public async Task UpdateMediaEntry(MediaList mediaList)
		{
			MediaEntryUpdate mediaEntryUpdate = MediaEntryUpdate.Convert(mediaList);
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.UpdateMediaEntry,
					Variables = mediaEntryUpdate
				};

				var response = await _graphQLClient.SendMutationAsync<Task>(request);
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		public async Task UpdateMediaFavoriteAnime(int? animeId)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.UpdateFavoriteMedia,
					Variables = new { animeId = animeId}
				};

				var response = await _graphQLClient.SendMutationAsync<Task>(request);
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		public async Task UpdateMediaFavoriteManga(int? mangaId)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.UpdateFavoriteMedia,
					Variables = new { mangaId = mangaId }
				};

				var response = await _graphQLClient.SendMutationAsync<Task>(request);
			}
			catch (Exception ex)
			{
				throw;
			}
		}

	}
}
