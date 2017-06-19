using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.Entities
{
    public class GrapeEntity
    {
        public String Name { get; set; }
        public int Percentage { get; set; }
    }
}