using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public async Task OnGet([FromRoute]int skip = 0, [FromRoute]int take = 25)
        {

            var temp = new List<Category>();

            await Task.Delay(1);
            for(int i = 1; i <= 1780; i++)
            {
                temp.Add(
                    new Category(
                        i, 
                        $"Categoria {i}", 
                        i*1.051M
                        )
                    );
            }

            Categories = temp.Skip(skip).Take(take).ToList();
        }
    }
}

public record Category (int Id, string Title, decimal Price);
