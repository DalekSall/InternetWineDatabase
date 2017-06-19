using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternetWineDatabase.Entities;

namespace InternetWineDatabase.BusinessLogic
{
    public class WineRepository : Repository<WineEntity>
    {
        public WineRepository() : base("Wine") {}

        //Overwriting parent function
        //public new WineEntity Get(string id)
        //{
        //    return null;
        //}
    }
}