using BulhyWebRazor_temp.Data;
using BulhyWebRazor_temp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulhyWebRazor_temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            CategoryList = _db.categories.ToList();
        }
    }
}