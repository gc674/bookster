namespace WebApplication1.Models
{
	public class RedirectItem
	{
		public RedirectItem(string text)
		{
			Text = text;
		}
		public RedirectItem(string text, string slug) : this(text)
		{
			Slug = slug;
		}
		public string Slug { get; set; } = "#";
		public string Text { get; set; }
	}
}
