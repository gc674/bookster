namespace WebApplication1.Models
{
    public class BookDetailViewModel
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
		public RedirectItem Author { get; set; }
		public string Description { get; set; }
        public float Rank { get; set; }
        public ImageViewModel Image { get; set; }
        public int NumberOfReviews { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfLoans { get; set; }
        public List<string> Awards { get; set; }
        public List<CategoryModel> Categories { get; set; }
        public List<RelatedItem> RelatedItems { get; set; }
	}
}
