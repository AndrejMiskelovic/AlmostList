using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.Common;
using System.Text.Json.Serialization;

namespace AlmostList.Client.Models.Properties.Media
{
    public class MediaList
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public int? MediaId { get; set; }
        public MediaListStatus? Status { get; set; }
		/// <summary>
		/// format of score by ScoreFormat
		/// </summary>
		public float? Score { get; set; } 
		public int? Progress { get; set; }
        public int? ProgressVolumes { get; set; }
        public int? Repeat { get; set; }
        public int? Priority { get; set; }
        public bool? Private { get; set; }
        public string? Notes { get; set; }
        public bool? HiddenFromStatusLists { get; set; }
        public Dictionary<string, bool>? CustomLists { get; set; }
        /// <summary>
        /// Json
        /// </summary>
        //public string? AdvancedScores { get; set; }
        public FuzzyDate? StartedAt { get; set; }
        public FuzzyDate? CompletedAt { get; set; }
        public int? UpdatedAt { get; set; }
        public int? CreatedAt { get; set; }
        public Media? Media { get; set; }
        public User.User? User { get; set; }
    }
}