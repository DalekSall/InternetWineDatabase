using InternetWineDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.BusinessLogic
{
    public class UserTypeRepository : Repository<UserTypeEntity>
    {
        public UserTypeRepository() : base("UserType") { }

    }
}