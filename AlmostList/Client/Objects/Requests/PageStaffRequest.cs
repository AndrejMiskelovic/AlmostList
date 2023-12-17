using AlmostList.Client.Models.Enums;
using AlmostList.Client.Objects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Objects.Requests
{
    public class PageStaffRequest
    {
        public int? Page { get; set; } = 1;
        public int? Id { get; set; }
        public string? Search { get; set; }
        public bool? IsBirthday { get; set; }
        public List<StaffSort>? Sort { get; set; } = new List<StaffSort>() { StaffSort.FAVOURITES_DESC };

    }
}
