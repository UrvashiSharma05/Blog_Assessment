using Blog_Assessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Assessment.Controllers
{
    public class BlogController : Controller
    {
      
            private readonly DataContext context;
            public BlogController(DataContext _context)
            {
                context = _context;
            }

            [HttpGet]
            public IActionResult Index()
            {
                var Student = context.blogPosts.ToList();
                return View(Student);
            }

            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpGet]
            public IActionResult Edit(int id)
            {
                var Student = context.blogPosts.Where(x => x.Id == id).FirstOrDefault();
                return View(Student);
            }

            [HttpGet]
            public IActionResult Details(int id)
            {
                var Student = context.blogPosts.Where(x => x.Id == id).FirstOrDefault();
                return View(Student);
            }

            [HttpGet]
            public IActionResult Delete(int id)
            {
                var Student = context.blogPosts.Where(x => x.Id == id).FirstOrDefault();
                return View(Student);
            }

           //----------

            [HttpPost]
            public IActionResult Create(BlogPosts student)
            {
                context.blogPosts.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            [HttpPost]
            public IActionResult Edit(BlogPosts student)
            {
                context.blogPosts.Update(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            [HttpPost]
            public IActionResult Delete(BlogPosts student)
            {
                context.blogPosts.Remove(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
}
