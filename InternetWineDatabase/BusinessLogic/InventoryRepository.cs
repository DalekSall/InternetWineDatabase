using InternetWineDatabase.BusinessLogic.ViewModels;
using InternetWineDatabase.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.BusinessLogic
{
    public class InventoryRepository : Repository<InventoryEntity>
    {
        public InventoryRepository() : base("Inventory") { }
 
        public IEnumerable<InventoryEntity> GetByWineId(string wineId)
        {
            var entities = EntityCollection.Find(inventory => inventory.WineId == wineId);
            var entityList = entities.ToList();
            return entityList;
        }
    }
}