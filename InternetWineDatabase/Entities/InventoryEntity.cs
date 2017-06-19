using InternetWineDatabase.BusinessLogic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.Entities
{
    public class InventoryEntity : IDbEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string WineId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string PurchaseId { get; set; }
        public int Quantity { get; set; }
        public string IntendedUse { get; set; }

        [BsonIgnore]
        public WineEntity Wine
        {
            get
            {
                var wineRepository = new WineRepository();
                return wineRepository.Get(WineId);
            }
            set { }
        }

        [BsonIgnore]
        public PurchaseEntity Purchase
        {
            get
            {
                var purchaseRepository = new PurchaseRepository();
                return purchaseRepository.Get(PurchaseId);
            }
            set { }
        }


    }
}