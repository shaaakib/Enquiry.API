using Enquiry.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enquiry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowCors")]
    public class EmployeeController : ControllerBase
    {
        private readonly UserDbContext _db;
        public EmployeeController(UserDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var employees = _db.Employee.ToList();
            return Ok(employees);
        }

        [HttpPost("CreateEmployee")]
        public IActionResult CreateEmployee([FromBody] EmployeeViewModel obj)
        {
            Employee _emp = new Employee()
            {
                name = obj.name,
                contactNo = obj.contactNo,
                email = obj.email,
                projectName = obj.projectName,
                city = obj.city,
                address = obj.address
            };

            _db.Employee.Add(_emp);
            _db.SaveChanges();

            foreach (var emp in obj.employeeFamilies)
            {
                EmployeeFamily _empFam = new EmployeeFamily()
                {
                    age = emp.age,
                    employeeId = _emp.employeeId,
                    name = emp.name,
                    relation = emp.relation
                };
                _db.EmployeeFamily.Add(_empFam);
                _db.SaveChanges();
            }

            return Created("Employee Created successfully", obj);
        }
    }
}
