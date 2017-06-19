using InternetWineDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.BusinessLogic
{
    public class PurchaseRepository : Repository<PurchaseEntity>
    {
        public PurchaseRepository() : base("Purchase") { }
    }
}