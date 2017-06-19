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
    public class TypeController : ApiController
    {
        public TypeRepository Repo { get; set; }

        public TypeController()
        {
            Repo = new TypeRepository();
        }
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<TypeEntity> Get()
        {
            return Repo.All();
        }

        // GET api/<controller>/5
        [HttpGet]
        public TypeEntity Get(string id)
        {
            return Repo.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]TypeEntity value)
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