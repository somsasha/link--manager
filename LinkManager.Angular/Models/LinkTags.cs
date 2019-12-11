namespace LinkManager.Angular.Models
{
    public class LinkTags
    {
        public int LinkId { get; set; }
        public virtual Link Link { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
