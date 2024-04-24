using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SMS.Data;
using SMS.Model;
using SMS.Model.Class2;
using System.Linq;

namespace SMS.Pages.Classroom.ClassTwo
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Class2> Classtwo { get; set; }
        public IEnumerable<Class2> Class2 { get; set; }

        public IndexModel(ApplicationDbContext _db)
        {
            _context = _db;
        }

        //FOR SEARCH
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? RollNo { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? StudentRollno { get; set; }
        //
        //public void OnGet()
        //{
        //    Classtwo = _context.ClassTwo;
        //    //var FirstStudent = _context.ClassTwo.FromSqlRaw("Select * from ClassTwo where Rollno = '1'");
        //    var FirstStudent = Classtwo.Where(u => u.Rollno.Equals(1));
        //}
        public async Task OnGetAsync()
        {
            Class2 = _context.ClassTwo;
            Classtwo = _context.ClassTwo;
            //var FirstStudent = _context.ClassTwo.FromSqlRaw("Select * from ClassTwo where Rollno = '1'");
            var FirstStudent = Classtwo.Where(u => u.Rollno.Equals(1));

            //FOR SEARCH
            var students = from m in _context.ClassTwo
                         select m;
            IQueryable<int> rollQuery = from m in _context.ClassTwo
                                        orderby m.Rollno
                                        select m.Rollno;
            if (!string.IsNullOrEmpty(SearchString))
            {
                students = students.Where(s => s.FullName.Contains(SearchString));
            }
            //if (!int.IsNullOrEmpty(StudentRollno))
            if(StudentRollno != null)
            {
                students = students.Where(x => x.Rollno.Equals(StudentRollno));
            }

            Classtwo = await students.ToListAsync();
            RollNo = new SelectList(await rollQuery.Distinct().ToListAsync());
            //
        }

    }
}
