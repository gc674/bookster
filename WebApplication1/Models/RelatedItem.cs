namespace WebApplication1.Models
{
	public class RelatedItem
	{
		public string Slug { get; set; }
		public string? Title { get; set; }
		public RedirectItem Author { get; set; }
        public ImageViewModel Image { get; set; }
    }
}
