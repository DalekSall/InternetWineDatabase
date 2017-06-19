using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.Entities
{
    public interface IDbEntity
    {
        string Id { get; set; }
    }
}