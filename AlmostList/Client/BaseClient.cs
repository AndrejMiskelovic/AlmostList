using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace AlmostList.Client
{
    public class BaseClient
    {
        private GraphQLHttpClient _graphQLClient = new GraphQLHttpClient("https://graphql.anilist.co", new NewtonsoftJsonSerializer());

        public async Task<GraphQLResponse<T>> GetData<T>(string query, object variables)
        {
            var request = new GraphQLRequest();
            request.Query = query;
            request.Variables = variables;
            return await _graphQLClient.SendQueryAsync<T>(request);
        }
    }
}


