using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Models
{
    public class PagesMediaResponse
    {
        public ListMedia Page;
    }

    public class ListMedia
    {
        public PageInfo PageInfo { get; set; }
        public Media[] Media { get; set; }
    }
    public class PageInfo
    {
       public int?  Total { get; set; }
       public int?  PerPage { get; set; }
       public int?  CurrentPage { get; set; }
       public int?  LastPage { get; set; }
       public bool  HasNextPage { get; set; }
    }
}
