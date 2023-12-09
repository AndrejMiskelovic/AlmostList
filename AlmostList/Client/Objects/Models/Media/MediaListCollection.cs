using AlmostList.Client.Models.Properties.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Objects.Models.Media
{
	public class MediaListCollection
	{
		public List<MediaListGroup>? Lists { get; set; }
		public User? User { get; set; }
		public bool? HasNextChunk { get; set; }

	}
}
