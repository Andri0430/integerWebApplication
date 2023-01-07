using integerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace integerWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new List<Student>();

            student.Add(new Student()
            {
                Id = 1,
                Name = "Andri",
                Addres = "Cirebon City",
                PhoneNumber = "0895606014734"
            });

            student.Add(new Student()
            {
                Id = 2,
                Name = "Putri Gumelar",
                Addres = "Cirebon",
                PhoneNumber = "08921412412421"
            });

            return View(student);
        }
    }
}
