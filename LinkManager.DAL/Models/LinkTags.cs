namespace LinkManager.DAL.Models
{
    public class LinkTags
    {
        public string LinkId { get; set; }
        public virtual Link Link { get; set; }
        public string TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
