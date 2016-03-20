using System;
using System.Collections.Generic;
using System.Linq;
using tshirt.Data;
using tshirt.Data.Models;

namespace tshirt.BusinessManagers.Tshirt {
    public class TshirtBusinessManager : ITshitBusinessManager {
        public IEnumerable<ProductType> GetProductTypes() {
            var db = TshirtContext.Create();
            try {
                return db.ProductTypes.ToList();
            } finally {
                db.Dispose();
            }
        }
    }
}