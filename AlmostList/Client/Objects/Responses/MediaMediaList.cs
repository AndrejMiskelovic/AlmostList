using AlmostList.Client.Models.Properties.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Models.Responses
{
	public class MediaMediaList
	{
		public Media? Media { get; set; }
		public MediaListEntry? MediaList { get; set; }
	}
}
