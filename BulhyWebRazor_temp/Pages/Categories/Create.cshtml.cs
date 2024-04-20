using Microsoft.AspNetCore.Mvc;
using BulhyWebRazor_temp.Data;
using BulhyWebRazor_temp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulhyWebRazor_temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
     
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
