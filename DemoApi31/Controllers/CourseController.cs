using DemoApi31.Model;
using DemoApi31.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly MainInterface<Course> _Course;

        public CourseController(MainInterface<Course> course)
        {
            _Course = course;
        }

        // GET: api/<CourseController>

        [HttpGet]

        public IActionResult GetAllCourse()
        {

            return Ok(_Course.GetAllDate());
        }

        // GET api/<CourseController>/5

        [HttpGet("{id}")]

        public IActionResult GetCourse(int id)
        {

            var employee = _Course.GetRowId(id);
            return Ok(employee);
        }
        // POST api/<CourseController>

        [HttpPost]
        public IActionResult AddCourse([FromBody] Course model)
        {
            if (ModelState.IsValid)
            {
                _Course.AddRow(model);
                return Ok(model);
            }
            return BadRequest(ModelState);
        }

        // PUT api/<CourseController>/5

        [HttpPut("{id}")]
        public IActionResult UpdateCourse( [FromBody] Course model)
        {
            _Course.UpdateRow(model);
            return Ok(model);
        }

        // DELETE api/<CourseController>/5

        [HttpDelete("{id}")]
        public void DeleteCourse(int id)
        {
            if (id == null || id == 0)
            {
                BadRequest(ModelState);
            }
            _Course.DeleteRow(id);
        }
    }
    
}

