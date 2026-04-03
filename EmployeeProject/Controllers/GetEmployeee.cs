using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmployeeProject.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ POST: Insert employees
        [HttpPost]
        public IActionResult SaveEmployees()
        {
            var employees = new List<EmpDto>
            {
                new EmpDto { EmpId = 5, EmpName = "Ram", EmpDomain = ".NET" },
                new EmpDto { EmpId = 6, EmpName = "Ravi", EmpDomain = "Testing" },
                new EmpDto { EmpId = 7, EmpName = "Sita", EmpDomain = "Angular" },
                new EmpDto { EmpId = 8, EmpName = "Gopal", EmpDomain = "SAP" }
            };

            _context.Employees.AddRange(employees);
            _context.SaveChanges();

            return Ok("Data inserted into Azure SQL DB successfully ✅");
        }

        // ✅ GET: Retrieve all employees
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        // ✅ GET: Health check
        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok("API is running 🚀");
        }
    }
}