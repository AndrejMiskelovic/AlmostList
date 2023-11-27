using AlmostList.Client.Models;
using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AlmostList.Client.Anime
{
    public class MediaRequest 
    {
        public async Task GetDataAsync()
        {
            var test = await new BaseClient(Queries.MediaQuery, new {Id = 154587 }.ToString()).GetData<Response<Media>>();
            Console.WriteLine(JsonSerializer.Serialize(test.Data.Media, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
