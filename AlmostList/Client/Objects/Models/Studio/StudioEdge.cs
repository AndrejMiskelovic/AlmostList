using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Models.Properties.Studio
{
	public class StudioEdge
	{
		public Studio? Node { get; set; }
		public int? Id { get; set; }
		public bool? IsMain { get; set; }
		public int? FavouriteOrder { get; set; }
	}
}
