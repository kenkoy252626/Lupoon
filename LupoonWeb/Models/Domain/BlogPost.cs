namespace LupoonWeb.Models.Domain
{
    public class BlogPost
    {
        //this is the property that go to database
        public Guid Id { get; set; }// is for Asp.Net   guid  ID
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeauturedImageUrl { get; set; }
        public string UrlHandle { get;set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

        public ICollection<Tag> Tag { get; set; }// this is connection to tag that can multiple relatioship
    }
}
