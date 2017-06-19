using InternetWineDatabase.BusinessLogic;
using InternetWineDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InternetWineDatabase.Controllers
{
    public class PurchaseController : ApiController
    {
        public PurchaseRepository Repo { get; set; }

        public PurchaseController()
        {
            Repo = new PurchaseRepository();
        }

        // GET api/<controller>
        [HttpGet]
        public IEnumerable<PurchaseEntity> Get()
        {
            return Repo.All();
        }

        // GET api/<controller>/5
        [HttpGet]
        public PurchaseEntity Get(string id)
        {
            return Repo.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]PurchaseEntity value)
        {
            Repo.Save(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}