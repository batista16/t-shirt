using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tshirt.Data.Models
{
    public class ProductColors
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Hex color number without hashtag
        /// </summary>
        [MaxLength(6)]
        public string Hex { get; set; }

        public virtual ICollection<ProductType> ProductTypes { get; set; }
    }
}