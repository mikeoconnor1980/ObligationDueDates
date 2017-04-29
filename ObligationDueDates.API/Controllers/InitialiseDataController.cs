using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObligationDueDates.Data;

namespace ObligationDueDates.API.Controllers
{
    [Produces("application/json")]
    [Route("api/InitialiseData")]
    public class InitialiseDataController : Controller
    {
        IObligationRepository _obligationRepository;

        // GET: api/InitialiseData
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/InitialiseData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/InitialiseData
        [HttpPost]
        public void Post([FromBody]string value, [FromServices] IObligationRepository obligationRepository)
        {
            _obligationRepository = obligationRepository;
            _obligationRepository.InitialiseData();
        }
        
        // PUT: api/InitialiseData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
