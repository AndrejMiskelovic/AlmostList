using AlmostList.Client.Models.Properties.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Objects.Responses
{
	public class MediaExternalLinkResponse
	{
		public List<MediaExternalLink>? ExternalLinkSourceCollection { get; set; }
	}
}
