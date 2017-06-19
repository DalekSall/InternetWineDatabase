using InternetWineDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetWineDatabase.BusinessLogic.ViewModels
{
    public class InventoryVM
    {
        public string Id { get; set; }
        public WineEntity Wine { get; set; }
        public int Quantity { get; set; }
        public string IntendedUse { get; set; }
    }
}