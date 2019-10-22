// I, Sang Tran, student number 000364912, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab1.Data;
using lab1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealershipApiController : ControllerBase
    {
        // GET: api/DealershipApi
        [HttpGet]
        public IEnumerable<Dealership> Get()
        {
            return DealershipMgr.GetDealerships();
        }

        // GET: api/DealershipApi/5
        [HttpGet("{id}", Name = "Get")]
        public Dealership Get(int id)
        {
            Dealership dealership = DealershipMgr.GetDealership(id);
            return dealership;
        }

        // POST: api/DealershipApi
        [HttpPost]
        public void Post([FromBody] Dealership dealership)
        {
            DealershipMgr.CreateDealership(dealership);
        }

        // PUT: api/DealershipApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dealership dealership)
        {
            DealershipMgr.UpdateDealershipApi(id, dealership);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DealershipMgr.DeleteDealership(id);
        }
    }
}
