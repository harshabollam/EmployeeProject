using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmployeeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetEmployeee : ControllerBase
    {
        private readonly AppDbContext _context;

        public GetEmployeee(AppDbContext context)
        {
            _context = context;
        }

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


        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok("API is running 🚀");
        }
    }
}
