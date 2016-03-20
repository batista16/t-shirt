using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using tshirt.Data;
using tshirt.Data.Models;

namespace tshirt.BusinessManagers.Tshirt {
    public class TshirtBusinessManager : ITshitBusinessManager {
        public IEnumerable<ProductType> GetProductTypes(bool includeDisabled = false) {
            var db = TshirtContext.Create();
            try {
                return db.ProductTypes
                    .Where(_ => includeDisabled || _.IsActive)
                    .Include(_=>_.ProductColors)
                    .ToList();
            } finally {
                db.Dispose();
            }
        }
    }
}