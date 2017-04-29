using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObligationDueDates.Objects;
using DocumentDBLibrary;
using ObligationDueDates.Data;

namespace ObligationDueDates.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Obligations")]
    public class ObligationsController : Controller
    {
        IObligationRepository _obligationRepository;

        // GET: api/Obligations
        [HttpGet]
        public IEnumerable<Obligation> Get([FromServices] IObligationRepository obligationRepository)
        {
            _obligationRepository = obligationRepository;
            return _obligationRepository.GetAll();
        }

        // GET: api/Obligations/5
        [HttpGet("{id}", Name = "Get")]
        public Obligation Get(string id, [FromServices] IObligationRepository obligationRepository)
        {
            _obligationRepository = obligationRepository;
            return  _obligationRepository.Get(id);
        }
        
        // POST: api/Obligations
        [HttpPost]
        public void Post([FromBody] Obligation value, [FromServices] IObligationRepository obligationRepository)
        {
            _obligationRepository = obligationRepository;
            _obligationRepository.Load();
        }
        
        // PUT: api/Obligations/5
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
