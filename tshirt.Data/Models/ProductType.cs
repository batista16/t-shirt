using System;
using System.Collections.Generic;

namespace tshirt.Data.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<ProductColors> ProductColors { get; set; }

        public virtual ICollection<ProductDesign> ProductDesigns { get; set; }
    }
}