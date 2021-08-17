using Api.Core.ApplicationServices;
using Api.Core.Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuantityApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly ICompanyGroupServices _companyGroupServices;

        public GroupController(ICompanyGroupServices companyGroupServices)
        {
            _companyGroupServices = companyGroupServices;
        }
        // GET: api/<GroupController>
        [HttpGet]
        public  ActionResult<IEnumerable<CompanyGroup>> Get()
        {
            try
            {
                string name = "name";
                var group = _companyGroupServices.ReadAllGroups(name);
                return Ok(group);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/<GroupController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GroupController>
        [HttpPost]
        public ActionResult<IEnumerable<CompanyGroup>> Post([FromBody] string value)
        {
            try
            {
                var group = _companyGroupServices.ReadAllGroups(value);
                return Ok(group);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
