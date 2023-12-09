﻿using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Requests;
using AlmostList.Client.Models.Responses;
using AlmostList.Client.Objects.Requests;
using AlmostList.Client.Objects.Responses;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace AlmostList.Client
{
    public class BaseClient
	{
		private GraphQLHttpClient _graphQLClient = new GraphQLHttpClient("https://graphql.anilist.co", new NewtonsoftJsonSerializer());
		private int? _currentUserId = null;

		public void SetToken(string token) 
		{
			_graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
		}
		public void SetCurrentUserId(int id)
		{
			_currentUserId = id;
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
		public async Task<GraphQLResponse<UserMainResponse>> GetUser(int? id, string? name)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.UserMain,
					Variables = new { id = id, name = name}
				};

				var response = await _graphQLClient.SendQueryAsync<UserMainResponse>(request);
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
		public async Task<GraphQLResponse<PageResponse<PagedAirSchedule>>> GetPageAiringSchedule(int page, int airingAtGreater, int airingArLeasser)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.GenresAndTagsCollection
				};

				var response = await _graphQLClient.SendQueryAsync<PageResponse<PagedAirSchedule>>(request);
				return response;
			}
			catch (Exception ex)
			{

				throw;
			}

		}
		public async Task<GraphQLResponse<PageResponse<PagedMedia>>> GetPageMedia(PageMediaRequest variables)
		{
			try
			{
				var request = new GraphQLRequest
				{
					Query = Queries.PageMedia,
					Variables = variables,
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
        public async Task<GraphQLResponse<PageResponse<PagedStaff>>> GetPageStaff(BaseRequest variables)
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
        public async Task<GraphQLResponse<PageResponse<PagedCharacter>>> GetPageCharacher(BaseRequest variables)
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

	}
}
