using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SMS.Data;
using SMS.Model;
using SMS.Model.Class2;

namespace SMS.Pages.Classroom.ClassTwo
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Class2> Classtwo { get; set; }
        public IList<Class2> FirstStudent { get; set; }
        
        public IndexModel(ApplicationDbContext _db)
        {
            _context = _db;
        }
        public void OnGet()
        {
            Classtwo = _context.ClassTwo;
            //var FirstStudent = _context.ClassTwo.FromSqlRaw("Select * from ClassTwo where Rollno = '1'");
            var FirstStudent = Classtwo.Where(u => u.Rollno.Equals(1));


        }
        
    }
}
