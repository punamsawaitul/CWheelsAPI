using CWheelsAPI.Data;
using CWheelsAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CWheelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        CWheelsDBContext _CWheelsDBContext;

        public VehiclesController(CWheelsDBContext cWheelsDBContext)
        {
            _CWheelsDBContext = cWheelsDBContext;
        }

        // GET: api/<VehiclesController>
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return _CWheelsDBContext.Vehicles;
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public Vehicle Get(int id)
        {
            return _CWheelsDBContext.Vehicles.Find(id);
        }

        // GET api/<VehiclesController>/Test/5
        [HttpGet("[action]/{id}")]
        public int Test(int id)
        {
            return id;
        }

        // POST api/<VehiclesController>
        [HttpPost]
        public void Post([FromBody] Vehicle value)
        {
            _CWheelsDBContext.Vehicles.Add(value);
            _CWheelsDBContext.SaveChanges();
        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Vehicle value)
        {
            var entity = _CWheelsDBContext.Vehicles.Find(id);

            entity.Title = value.Title;
            entity.Price = value.Price;
            _CWheelsDBContext.SaveChanges();
        }

        // DELETE api/<VehiclesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var entity = _CWheelsDBContext.Vehicles.Find(id);

            _CWheelsDBContext.Vehicles.Remove(entity);
            _CWheelsDBContext.SaveChanges();
        }
    }
}
