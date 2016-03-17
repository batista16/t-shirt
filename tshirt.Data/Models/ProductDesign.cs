using System;

namespace tshirt.Data.Models
{
    public class ProductDesign
    {
        public int Id { get; set; }

        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedById { get; set; }
        public virtual ApplicationUser CreatedBy { get; set; }
    }
}