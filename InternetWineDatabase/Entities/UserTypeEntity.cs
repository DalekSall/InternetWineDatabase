using InternetWineDatabase.BusinessLogic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.Entities
{
    public class UserTypeEntity : IDbEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string TypeId { get; set; }
        public List<string> Value { get; set; }

        [BsonIgnore]
        public TypeEntity Type
        {
            get
            {
                var typeRepository = new TypeRepository();
                return typeRepository.Get(TypeId);
            }
            set { }
        }

    }
}