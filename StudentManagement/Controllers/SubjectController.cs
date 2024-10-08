using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;

namespace StudentManagement.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Teachers = _context.Teachers.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Subject subject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            ViewBag.Teachers = _context.Teachers.ToList();
            return View(subject);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var subjects = await _context.Subjects.Include(s => s.Teacher).ToListAsync();
            return View(subjects);
        }
    }

}
