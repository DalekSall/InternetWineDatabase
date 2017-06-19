using InternetWineDatabase.BusinessLogic;
using InternetWineDatabase.BusinessLogic.ViewModels;
using InternetWineDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InternetWineDatabase.Controllers
{
    public class InventoryController : ApiController
    {
        // GET api/<controller>
        public InventoryRepository Repo { get; set; }

        public InventoryController()
        {
            Repo = new InventoryRepository();
        }
        [HttpGet]
        public IEnumerable<InventoryEntity> Get()
        {
            return Repo.All();
        }

        [HttpGet]
        public IEnumerable<InventoryEntity> GetByWine(string id)
        {
            return Repo.GetByWineId(id);
        }

        // GET api/<controller>/5
        [HttpGet]
        public InventoryEntity Get(string id)
        {
            return Repo.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]InventoryEntity value)
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