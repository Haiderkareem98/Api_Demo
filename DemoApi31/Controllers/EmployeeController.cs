using DemoApi31.Model;
using DemoApi31.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DemoApi31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly MainInterface<Employee> _Employee;

        public EmployeeController(MainInterface<Employee> employee)
        {
            _Employee = employee;
        }

        // GET: api/<EmployeeController>

        [HttpGet]
        public IActionResult GetAllEmplyee()
        {
            
            return Ok(_Employee.GetAllDate());
        }


        // GET api/<EmployeeController>/5

        [HttpGet("{id}")]
        public IActionResult GetEmplyee(int id)
        {
            var employee =  _Employee.GetRowId(id);
            return Ok(employee);
        }

        // POST api/<EmployeeController>

        [HttpPost]
        public IActionResult AddEmplyee([FromBody] Employee model)
        {
            if (ModelState.IsValid)
            {
                _Employee.AddRow(model);
                return Ok(model);
            }
            return BadRequest(ModelState);
        }

        // PUT api/<EmployeeController>/5

        [HttpPut("{id}")]
        public IActionResult UpdateEmplyee( [FromBody] Employee model)
        {
           _Employee.UpdateRow(model);
            return Ok(model);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void DeleteEmplyee(int id)
        {
            if (id == null || id == 0)
            {
               // ModelState.AddModelError("Error", "this Id Not Found");
                BadRequest(ModelState);
            }
            _Employee.DeleteRow(id);
        }
    }
}
