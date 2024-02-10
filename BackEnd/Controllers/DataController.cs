using Microsoft.AspNetCore.Mvc;
using SmallApp.Models;
using Newtonsoft.Json;

namespace SmallApp.Controllers
{
    [ApiController]
    public class DataController : Controller
    {

        [HttpGet("/data")]
        public string Index()
        {
            List<BookModel> books = new()
            {
                new BookModel {Id = 1, Title = "Clean Code: A Handbook of Agile Software Craftsmanship", Author = "Robert C. Martin", PublishDate = "08/10/2008", ImageUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg"},
                new BookModel {Id = 2, Title = "Introduction to Algorithms", Author = "Thomas H. Cormen", PublishDate = "1/10/2015" , ImageUrl = "https://hackr.io/blog/uploads/images/introduction-to-algorithms-eastern-economy-edition.jpg"},
                new BookModel {Id = 3, Title = "Structure and Interpretation of Computer Programs", Author = "Harold Abelson", PublishDate = "9/10/1996" , ImageUrl = "https://hackr.io/blog/uploads/images/structure-and-interpretation-of-computer-programs-2nd-edition-mit-electrical-engineering-and-computer-science1.jpg"},
                new BookModel {Id = 4, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", PublishDate = "9/10/2019" , ImageUrl = "https://hackr.io/blog/uploads/images/the-pragmatic-programmer-your-journey-to-mastery-20th-anniversary-edition-2nd-edition-2nd-edition.jpg"},
                new BookModel {Id = 5, Title = "Head First Design Patterns", Author = "Eric Freeman", PublishDate = "8/10/2004" , ImageUrl = "https://hackr.io/blog/uploads/images/head-first-design-patterns-a-brain-friendly-guide-1st-edition.jpg"}
            };

            return JsonConvert.SerializeObject(books);
        }
    }
}
