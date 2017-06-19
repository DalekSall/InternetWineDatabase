using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InternetWineDatabase.Entities;
using InternetWineDatabase.BusinessLogic;

namespace InternetWineDatabase.Controllers
{
    public class WineController : ApiController
    {
        public WineRepository Repo { get; set; }
        public WineController()
        {
             Repo = new WineRepository();
        }
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<WineEntity> Get()
        {
            return Repo.All();
        }

        // GET api/<controller>/5
        [HttpGet]
        public WineEntity Get(string id)
        {
            return Repo.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]WineEntity value)
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