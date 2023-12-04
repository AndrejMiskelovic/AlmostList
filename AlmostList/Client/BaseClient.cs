using AlmostList.Client.Anime;
using AlmostList.Client.Models;
using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties;
using AlmostList.Client.Models.Responses;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AlmostList.Client
{
    public class BaseClient
	{
		private GraphQLHttpClient _graphQLClient = new GraphQLHttpClient("https://graphql.anilist.co", new NewtonsoftJsonSerializer());

		public void SetToken(string token) 
		{
			_graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
		}
		public async Task<GraphQLResponse<MediaResponse>> GetMedia(int id)
		{
			var request = new GraphQLRequest
			{
				Query = Queries.Media,
				Variables = new { id = id }
			};

			var response = await _graphQLClient.SendQueryAsync<MediaResponse>(request);
			return response;
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

	}
}
