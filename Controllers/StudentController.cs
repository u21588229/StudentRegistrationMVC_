using Microsoft.AspNetCore.Mvc;
using StudentRegistrationMVC_.Models;

namespace StudentRegistrationMVC_.Controllers
{
    public class StudentController : Controller
    {

        private static List<Student> students = new List<Student>();

        // GET: Student
        public IActionResult Index()
        {
            /*var students = new List<Student>
            {
                new Student { Id = 1, Name = "Laptop", Email = "dbhjfkem@gmail.com" },
                new Student { Id = 2, Name = "Mouse", Email = "fjdhf@gmail.com" },
                new Student { Id = 3, Name = "Keyboard", Email = "feygnf@gmail.com" }
            };*/

            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");
        }
    }
}
