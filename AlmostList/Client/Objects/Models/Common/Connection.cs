namespace AlmostList.Client.Models.Properties.Common
{
    public class Connection<T, A>
    { 
        public List<T>? Edges { get; set; }
        public List<A>? Nodes { get; set; }
        public PageInfo? PageInfo { get; set; }
    }
}