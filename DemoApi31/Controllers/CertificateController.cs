using DemoApi31.Model;
using DemoApi31.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly MainInterface<Certificate> _Certificate;

        public CertificateController(MainInterface<Certificate> certificate)
        {
            _Certificate = certificate;
        }


        // GET: api/<CertificateController>

        [HttpGet]

        public IActionResult GetAllCertificate()
        {

            return Ok(_Certificate.GetAllDate());
        }

        // GET api/<CertificateController>/5

        [HttpGet("{id}")]

        public IActionResult GetCertificate(int id)
        {

            var certificate = _Certificate.GetRowId(id);
            return Ok(certificate);
        }

        // POST api/<CertificateController>

        [HttpPost]
        public IActionResult AddCertificate([FromBody] Certificate model)
        {
            if (ModelState.IsValid)
            {
                _Certificate.AddRow(model);
                return Ok(model);
            }
            return BadRequest(ModelState);
           
        }

        // PUT api/<CertificateController>/5

        [HttpPut("{id}")]
        public IActionResult UpdateCertificate( [FromBody] Certificate model)
        {
            _Certificate.UpdateRow(model);
            return Ok(model);
        }

        // DELETE api/<CertificateController>/5

        [HttpDelete("{id}")]
        public void DeleteCertificate(int id)
        {
            if (id == null || id == 0)
            {
                BadRequest(ModelState);
            }
            _Certificate.DeleteRow(id);
        }

    }
}
