using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Eletronics" });
            departments.Add(new Department { Id = 2, Name = "Fashion" });
            departments.Add(new Department { Id = 3, Name = "Computers" });

            return View(departments);
        }
    }
}
