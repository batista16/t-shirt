using System.Collections.Generic;
using tshirt.Data.Models;

namespace tshirt.Web.ViewModels {
    public class DesignerVm {
        public IEnumerable<ProductType> ProductTypes { get; set; }
    }
}