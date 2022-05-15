using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BooksController : Controller
    {
        [Route("books/{slug}")]
        public IActionResult Index(string slug)
        {
            var categories = new List<CategoryModel> { new CategoryModel
            {
                Title = "Romane filozofie",
                Logo = "cat-bookster.svg",
                Slug = "categories/bookster-awards"
            },
            new CategoryModel
            {
                Title = "Istorie si cultura",
                Logo = "cat-bookster.svg",
                Slug = "categories/bookster-awards"
            },
            new CategoryModel
            {
                Title = "Top 10+ Polirom",
                Slug = "categories/bookster-awards"
            },
            new CategoryModel
            {
                Title = "Rezilienta",
                Slug = "categories/bookster-awards"
            },
            new CategoryModel
            {
                Title = "Ocolul Pamantului",
                Slug = "categories/bookster-awards"
            },
            new CategoryModel
            {
                Title = "ProvoCARTEA 2022",
                Slug = "categories/bookster-awards"
            },
            new CategoryModel
            {
                Title = "De la carti la filme",
                Slug = "categories/bookster-awards"
            },
            new CategoryModel
            {
                Title = "Carti care te pe ganduri",
                Slug = "categories/bookster-awards"
            },
            new CategoryModel
            {
                Title = "Carti de aventura",
                Slug = "categories/bookster-awards"
            }};

            var relatedItems = new List<RelatedItem>
            {
                new BookSummary
                {
                    Title = "Evanghelia dupa Pilat",
                    Author = new RedirectItem("Emmanuel Schmitt"),
                    Slug = "evanghelia-dupa-pilat",
                    Image = new ImageViewModel { Path ="evanghelia-dupa-pilat.png", AlternativeText="Evanghelia dupa Pilat" }
                },
                new BookSummary
				{
                    Title = "Vechiul oras imperial",
                    Author = new RedirectItem("Yasunari Kawabata"),
                    Slug = "vechiul-oras-imperial",
                    Image = new ImageViewModel { Path = "vechiul-oras-imperial.jpg", AlternativeText="Vechiul oras imperial" }
				},
                new ArticleSummary
				{
                    Author = new RedirectItem("Bookster"),
                    ImageBackground = "blue",
                    Slug = "recomandarile-bibliotecarilor-pentru-luna-noiembrie",
                    ImageText = "Recomandarile bibliotecarilor pentru luna noiembrie"
				},
                new BookSummary
				{
                    Title = "Doamna Chiajna",
                    Author = new RedirectItem("Alexandru Odobescu"),
                    Image = new ImageViewModel { Path = "doamna-chiajna.png", AlternativeText="Doamna Chiajna" },
                    Slug = "doamna-chiajna",
                    IsEbook = true
				},
                new ArticleSummary
                {
                    Title = "Istoria versus Sigmund Freud",
                    Author = new RedirectItem("Ted-Ed"),
                    Image = new ImageViewModel { Path = "istoria-versus-sigmund-freud.png", AlternativeText="Istoria versus Sigmund Freud" },
                    Slug = "istoria-versus-sigmund-freud",
                    IsVideo = true
				},
                 new BookSummary
                 {
                    Title = "Imago",
                    Author = new RedirectItem("Ludmila Ulitkaia"),
                    Image = new ImageViewModel { Path = "imago.png", AlternativeText="Imago"},
                    Slug = "imago"
                }
            };

            var book = new BookDetailViewModel
            {
                Id = 1,
                Slug = "life-of-pi",
                Title = "Viata lui Pi",
                Author = new RedirectItem("Yann Martel"),
                Description = "Pi Patel este fiul unui paznic de gradina zoologica, isi duce viata printre animale si apleaca urechea la o multime de povesti despre hinduism, islam si crestinism. Cand implineste saisprezece ani, el pleaca impreuna cu familia si cu salbaticiunile tinute in custi spre America de Nord, la bordul unei nave japoneze. Vasul naufragiaza, iar Pi se catara intr-o barca de salvare, la un loc cu un urangutan, o zebra ranita si un tigru bengalez. Ceea ce promitea sa devina o robinsoniada moderna se transforma intr-o aventura transpacifica a la Kon Tiki, din care nu lipsesc ingredientele romanului fantastic, nici tensiunile surprinse de Gericault in Pluta Meduzei. Mai mult, Pi imprumuta de la Seherezada arta povestirii pentru a i se face util tigrului, dupa ce acesta ii infuleca pe ceilalti pasageri din barca. Viata lui Pi este o poveste pe cat de realista in detaliile ei pamantesti, pe atat de fabuloasa, parca scoasa din sertarul cu plasmuiri al lui Edgar Allan Poe.",
                Rank = 6.7F,
                Image = new ImageViewModel
                {
                    Path = "life-of-pi.jpg",
                    AlternativeText = "Viata lui Pi"
                },
                NumberOfReviews = 44,
                NumberOfPages = 336,
                NumberOfLoans = 1443,
                Awards = new List<string> { "Man Booker Prize" },
                Categories = categories,
                RelatedItems = relatedItems
            };
            List<BookDetailViewModel> books = new List<BookDetailViewModel> { book };

            var vm = books.SingleOrDefault(x => x.Slug == slug);
            if (vm != null)
            {
                return View(book);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
