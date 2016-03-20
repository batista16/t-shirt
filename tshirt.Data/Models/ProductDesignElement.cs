namespace tshirt.Data.Models
{
    public class ProductDesignElement
    {
        public int Id { get; set; }
        public int ProductDesignId { get; set; }
        public virtual ProductDesign ProductDesign{ get; set; } 
    }
}