using System.Collections.Generic;
using tshirt.Data.Models;

namespace tshirt.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<tshirt.Data.TshirtContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(tshirt.Data.TshirtContext context)
        {
            var productColorses = new[]
            {
                new ProductColors()
                {
                    Name = "Branco",
                    Hex = "FFFFFF"
                },
                new ProductColors()
                {
                    Name = "Preto",
                    Hex = "000000"
                },
                new ProductColors()
                {
                    Name = "Azul",
                    Hex = "3333FF"
                }
            };
            context.ProductColors.AddOrUpdate(_=>_.Name,productColorses);
            context.ProductTypes.AddOrUpdate(_=>_.Name,new[]
            {
                new ProductType()
                {
                    CreatedOn = DateTime.UtcNow,
                    IsActive = true,
                    Name = "T-Shirt Feminino",
                    ProductColors = productColorses
                },
                new ProductType()
                {
                    CreatedOn = DateTime.UtcNow,
                    IsActive = true,
                    Name = "T-Shirt Masculino",
                    ProductColors = productColorses
                }
            });
            context.SaveChanges();
        }
    }
}
