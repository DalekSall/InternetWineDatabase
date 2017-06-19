using InternetWineDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.BusinessLogic
{
    public class TypeRepository : Repository<TypeEntity>
    {
        public TypeRepository() : base("Type") { }
    }
}