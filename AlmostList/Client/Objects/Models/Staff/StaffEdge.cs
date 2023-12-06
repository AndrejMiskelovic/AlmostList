using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Models.Properties.Staff
{
	public class StaffEdge
	{
		public Staff? Node { get; set; }
		public int? Id { get; set; }
		public string? Role { get; set; }
		public int? FavouriteOrder { get; set; }
	}
}
