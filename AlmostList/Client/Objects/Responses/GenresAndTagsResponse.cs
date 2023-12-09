using AlmostList.Client.Models.Properties.Media;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Models.Responses
{
    public class GenresAndTagsResponse
    {
        public List<string>? Genres { get; set; }
        public List<MediaTag>? MediaTags { get; set; }
    }
}
