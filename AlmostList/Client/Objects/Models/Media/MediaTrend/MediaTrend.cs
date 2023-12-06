using AlmostList.Client.Models.Properties.User;
using Android.Nfc;
using Android.Telecom;
using Google.Android.Material.Color.Utilities;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostList.Client.Models.Properties.Media.MediaTrend
{
    public class MediaTrend
    {
		public int? MediaId { get; set; }
		public int? Date { get; set; }
		public int? Trending { get; set; }
		public int? AverageScore { get; set; }
		public int? Popularity { get; set; }
		public int? InProgress { get; set; }
		public bool? Releasing { get; set; }
		public int? Episode { get; set; }
		public Media? Media { get; set; }
	}
}
