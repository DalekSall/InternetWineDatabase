using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternetWineDatabase.Entities;
using System.Configuration;

namespace InternetWineDatabase.BusinessLogic
{
    public class Repository <T> where T : IDbEntity
    {
        protected IMongoDatabase Db;
        protected string Entity;
        public IMongoCollection<T> EntityCollection
        {
            get { return Db.GetCollection<T>(Entity); }
        }

        public Repository(string entity)
        {
            string dbName = ConfigurationManager.ConnectionStrings["MongoDbConnection"].ConnectionString;

            MongoClient client = new MongoClient();
            Db = client.GetDatabase(dbName);
            Entity = entity;
            //var collection = db.GetCollection<T>(this.entity);
        }

        public T Get(string id)
        {
            return EntityCollection.Find(_ => _.Id == id).SingleOrDefault<T>();
        }

        public T Save(T entity)
        {
            EntityCollection.InsertOne(entity);
            return entity;
        }

        public IEnumerable<T> All()
        {
            var entities = EntityCollection.Find(_ => true);
            var entityList = entities.ToList();
            return entityList;
        }
    }
}