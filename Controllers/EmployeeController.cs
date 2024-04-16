using EmployeeTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTask.Controllers
{
    public class EmployeeController : Controller
    {
        Employee[] employees = [
            new Employee() { EmployeeId = 1, FirstName = "yousef", LastName = "mandani", Department = "IT", Email = "mail@mail.com" },
            new Employee() { EmployeeId = 2, FirstName = "tareq", LastName = "mandani", Department = "IT", Email = "mail@mail.com" },
            new Employee() { EmployeeId = 3, FirstName = "omar", LastName = "mandani", Department = "IT", Email = "mail@mail.com" },
        ];
        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var employee = employees.Single(e => e.EmployeeId == id);
            if(employee == null)
            {
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}
