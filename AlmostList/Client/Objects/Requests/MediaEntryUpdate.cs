using AlmostList.Client.Models.Enums;
using AlmostList.Client.Models.Properties.Common;
using System;
using System.Collections.Generic;
using AlmostList.Client.Models.Properties.Media;
using AlmostList.Client.Models.Properties.User;

namespace AlmostList.Client.Objects.Requests
{
	public class MediaEntryUpdate
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
		public List<string>? CustomLists { get; set; }
		public FuzzyDate? StartedAt { get; set; }
		public FuzzyDate? CompletedAt { get; set; }
		public int? UpdatedAt { get; set; }
		public int? CreatedAt { get; set; }
		public Media? Media { get; set; }
		public User? User { get; set; }
	}

	public static class MediaListToMediaEntryUpdate
	{
		public static MediaEntryUpdate Convert(MediaList mediaList)
		{
			MediaEntryUpdate mediaEntryUpdate = new MediaEntryUpdate();
			mediaEntryUpdate.Id = mediaList.Id;
			mediaEntryUpdate.UserId = mediaList.UserId;
			mediaEntryUpdate.MediaId = mediaList.MediaId;
			mediaEntryUpdate.Status = mediaList.Status;
			mediaEntryUpdate.Score = mediaList.Score;
			mediaEntryUpdate.Progress = mediaList.Progress;
			mediaEntryUpdate.ProgressVolumes = mediaList.ProgressVolumes;
			mediaEntryUpdate.Repeat = mediaList.Repeat;
			mediaEntryUpdate.Priority = mediaList.Priority;
			mediaEntryUpdate.Private = mediaList.Private;
			mediaEntryUpdate.Notes = mediaList.Notes;
			mediaEntryUpdate.HiddenFromStatusLists = mediaList.HiddenFromStatusLists;
			foreach (var customList in mediaList.CustomLists)
			{
				if (customList.Value)
				{
					if (mediaEntryUpdate.CustomLists == null)
						mediaEntryUpdate.CustomLists = new List<string>();

					mediaEntryUpdate.CustomLists.Add(customList.Key);
				}
			}
			mediaEntryUpdate.StartedAt = mediaList.StartedAt;
			mediaEntryUpdate.CompletedAt = mediaList.CompletedAt;
			mediaEntryUpdate.UpdatedAt = mediaList.UpdatedAt;
			mediaEntryUpdate.CreatedAt = mediaList.CreatedAt;
			mediaEntryUpdate.Media = mediaList.Media;
			mediaEntryUpdate.User = mediaList.User;
			return mediaEntryUpdate;
		}
	}

}
