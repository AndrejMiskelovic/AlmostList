using Java.Util;
using static System.Collections.Specialized.BitVector32;

namespace AlmostList.Client.Models.Properties.User
{
	public class MediaListTypeOptions
	{
		public List<string>? SectionOrder {  get; set; }
		public bool SplitCompletedSectionByFormat {  get; set; }
		public List<string>? CustomLists {  get; set; }
		public List<string>? AdvancedScoring {  get; set; }
		public bool AdvancedScoringEnabled {  get; set; }
	}
}