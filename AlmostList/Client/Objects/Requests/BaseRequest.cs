using AlmostList.Client.Objects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Objects.Requests
{
    public class BaseRequest
    {
        public int? Page { get; set; } = 1;
        public int? Id { get; set; }
        public string? Search { get; set; }
        public bool? IsBirthday { get; set; }
        public List<CharacterSort>? Sort { get; set; } = new List<CharacterSort>() { CharacterSort.FAVOURITES_DESC };

    }
}
