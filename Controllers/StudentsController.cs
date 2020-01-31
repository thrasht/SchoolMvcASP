using Microsoft.AspNetCore.Mvc;
using School.Models;
using System.Linq;

namespace School.Controllers
{
    public class StudentsController : Controller
    {
        private SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }
        
        public IActionResult prueba() 
        {
            var students = _context.Students.ToList();
            
            return View(students);
        }
        
    }
}