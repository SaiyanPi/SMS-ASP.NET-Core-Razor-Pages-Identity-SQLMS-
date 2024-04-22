using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMS.Data;
using SMS.Model;

namespace SMS.Pages.Classroom
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Classes> Classes { get; set; }
        public IndexModel(ApplicationDbContext _db)
        {
                _context = _db;
        }
        public void OnGet()
        {
            Classes = _context.ClassesList;
        }
    }
}
