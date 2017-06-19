using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.Entities
{
    public class WineEntity : IDbEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Country { get; set; }
        public string Area { get; set; }
        public IList<GrapeEntity> Grape { get; set; }
        public int Vintage { get; set; }
        public double Vol { get; set; }
    }
}