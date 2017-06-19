using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.Entities
{
    public class PurchaseEntity : IDbEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Seller { get; set; }
        public string Comment { get; set; }
        public int BuyPrice { get; set; }
        public int NormalPrice { get; set; }
    }
}