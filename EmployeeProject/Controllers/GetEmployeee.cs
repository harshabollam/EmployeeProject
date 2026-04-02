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
            new EmpDto { EmpId = 1, EmpName = "Ram", EmpDomain = ".NET" },
            new EmpDto { EmpId = 2, EmpName = "Ravi", EmpDomain = "Testing" },
            new EmpDto { EmpId = 3, EmpName = "Sita", EmpDomain = "Angular" },
            new EmpDto { EmpId = 4, EmpName = "Gopal", EmpDomain = "SAP" }
        };

            _context.Employees.AddRange(employees);
            _context.SaveChanges();

            return Ok("Data inserted into Azure SQL DB successfully ✅");
        }
    }
}
