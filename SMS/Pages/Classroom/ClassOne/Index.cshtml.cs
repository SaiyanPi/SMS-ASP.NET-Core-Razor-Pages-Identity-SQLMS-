using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMS.Data;
using SMS.Model;
using SMS.Model.Class1;

namespace SMS.Pages.Classroom.ClassOne
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Class1> Classone { get; set; }
        public IndexModel(ApplicationDbContext _db)
        {
            _context = _db;
        }
        public void OnGet()
        {
            Classone = _context.ClassOne;
        }
    }
}
