using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ascent_lab_blog_frontend.Pages.Components.Buttons;

public class Button : PageModel
{
    public object Text { get; set; }

    public void OnGet()
    {
    }
}