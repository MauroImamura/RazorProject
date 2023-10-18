using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public async Task OnGet()
        {
            await Task.Delay(1);
            for(int i = 1; i <= 100; i++)
            {
                Categories.Add(
                    new Category(
                        i, 
                        $"Categoria {i}", 
                        i*1.051M
                        )
                    );
            }
        }

        public void OnPost()
        {
        }
    }
}

public record Category (int Id, string Title, decimal Price);
