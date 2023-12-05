namespace AlmostList.Client.Models.Properties.Common
{
    public class Name
    {
        public string? First { get; set; }
        public string? Middle { get; set; }
        public string? Last { get; set; }
        public string? Full { get; set; }
        public string? Native { get; set; }
        public List<string>? Alternative { get; set; }
        public List<string>? UserPreferred { get; set; }
    }
}