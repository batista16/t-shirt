using System.Collections.Generic;
using tshirt.Data.Models;

namespace tshirt.BusinessManagers.Tshirt
{
    public interface ITshitBusinessManager
    {
        IEnumerable<ProductType> GetProductTypes();
    }
}