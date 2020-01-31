using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Models.ViewModels;
using System.Linq;
using System.Collections.Generic;


namespace School.Controllers

{
    public class SchoolController : Controller
    {
        private SchoolContext _context;

        public SchoolController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //List<SchoolView> sv = new List<SchoolView>();

            var school = _context.School.FirstOrDefault();
/*
            foreach (var oElement in school) {
                SchoolView s = new SchoolView();

                s.Name = oElement.Name;
                s.Year = oElement.Year;

                sv.Add(s);
            }
*/
            return View(school);
        }

        public IActionResult Index_2()
        {
            return View();
        }
    }
}