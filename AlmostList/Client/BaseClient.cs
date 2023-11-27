using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace AlmostList.Client
{
    public class BaseClient
    {
        private GraphQLHttpClient _graphQLClient = new GraphQLHttpClient("https://graphql.anilist.co", new NewtonsoftJsonSerializer());
        private GraphQLRequest _request = new GraphQLRequest();
        public BaseClient(string query, object variables)
        {
            _request.Query = query;
            _request.Variables = variables;
        }

        public async Task<GraphQLResponse<T>> GetData<T>()
        {
            GraphQLResponse<T> graphQLResponse = await _graphQLClient.SendQueryAsync<T>(_request);
            return graphQLResponse;
        }
    }
}


