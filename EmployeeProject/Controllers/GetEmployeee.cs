using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmployeeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetEmployeee : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var employees = new List<EmpDto>
    {
        new EmpDto { EmpId = 1, EmpName = "Ram", EmpDomain = ".NET" },
        new EmpDto { EmpId = 2, EmpName = "Ravi", EmpDomain = "Testing" },
        new EmpDto { EmpId = 3, EmpName = "Sita", EmpDomain = "Angular" }
    };

            return Ok(employees);
        }
    }
}
