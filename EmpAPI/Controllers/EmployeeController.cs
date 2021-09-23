using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpAPI.Repository;
using EmpAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeRepository empRepository;

        public EmployeeController()
        {
            EmployeeContext context = new EmployeeContext();
            empRepository = new EmployeeRepository(context);
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return empRepository.GetEmployees();
            //return new string[] { "value1", "value2", value.ToString() };

        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            
            try
            {
                return empRepository.GetEmployeeByID(id);
            }
            catch
            {
                return NotFound();
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult Post(Employee value)
        {
            empRepository.InsertEmployee(value);
            try
            {
                empRepository.Save();
                return StatusCode(200);
            }
            catch
            {
                return NoContent();
            }
        }

        // PUT api/<EmployeeController>
        [HttpPut]
        public ActionResult Put(Employee value)
        {
            empRepository.UpdateEmployee(value);
            try
            {
                empRepository.Save();
                return StatusCode(200);
            } catch
            {
                return NotFound();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            empRepository.DeleteEmployee(id);
            try
            {
                empRepository.Save();
                return StatusCode(200);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
