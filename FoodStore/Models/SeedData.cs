using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
//using System;

namespace FoodStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            /* public static void EnsurePopulated(IServiceProvider services)
             {
                 ApplicationDbContext context =
                 services.GetRequiredService<ApplicationDbContext>();
                 //context.Database.Migrate();*/

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Beekeeper's Naturals B. Powered Superfood Honey",
                    Description = "Hive powered complex. Royal jelly for clarity. Pollen for the body. Propolis for resilience. Honey for the soul.",
                    Category = "Honey",
                    Price = 39.99m
                },
                new Product
                {
                    Name = "Beekeeper's Naturals 100% Raw Wildflower Honey",
                    Description = "Coming from remote apiaries full of healthy bees pollinating diverse plants and flowers, this honey contains a naturally rich and fresh flavour",
                    Category = "Honey",
                    Price = 17.99m
                },
                new Product
                {
                    Name = "Hot Mamas Red Pepper Jelly",
                    Description = "Hot Mamas Red Pepper Jelly is perfect for cheese and crackers, hors d'oeuvres, basting sauces for meats, fish and poultry. Great as dipping sauce on egg rolls, spring rolls, samosas and much, much more! Taste the difference with their home grown Scotch bonnet peppers used in this delicious jelly! Hot Mamas gets bonus points for being all natural, free from MSG and gluten.",
                    Category = "Pepper Jelly",
                    Price = 8.29m
                },
                new Product
                {
                    Name = "GoGo Quinoa Organic Instant Buckwheat Flakes",
                    Description = "GoGo Quinoa instant Buckwheat Flakes can be used instead of regular flakes in muffins, smoothies, patties and other recipes.",
                    Category = "Organic",
                    Price = 5.99m
                },
                new Product
                {
                    Name = "PRANA Extaze Organic Sea Salted Cashews",
                    Description = "Sweet and milky, this unique cashew mix has been lightly sea salted without any oil, often found in conventional nut mixes. Thanks to Prana's unique innovative method, they've finely coated their cashews to offer pure extasy! ",
                    Category = "Organic",
                    Price = 8.99m
                },
                new Product
                {
                    Name = "Castle Kitchen Hot Chocolate Double Dutch Dark Chocolate",
                    Description = "Rich and creamy, this flavour warms the chocolate lover in all of us.",
                    Category = "Chocolate ",
                    Price = 8.29m
                },
                new Product
                {
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent a disadvantage",
                    Category = "Chess",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "Crofter's Organic Morello Cherry Premium Spread",
                    Description = "With only 30 calories per serving, Crofter's fruit spreads have 33% less sugar than a traditional jam, which means you get more fruit and less sugar with every tasty bite! The morello cherry is a powerhouse of antioxidants, and this sweetly tart cherry is perfectly suited for a spread.",
                    Category = "Organic ",
                    Price = 4.99m
                },
                 new Product
                 {
                    Name = "Wildly Delicious Applewood & Hickory Smoked Barbecue Sauce",
                    Description = "Wildly Delicious Applewood & Hickory Smoked Barbecue Sauce offers big, smoky flavour that is impossibly addictive. Wildly Delicious Applewood & Hickory Smoked Barbecue needs to reside in your pantry because if smoky BBQ is your thing, this sauce will be the only one you will ever use. Please use responsibly",
                    Category = "Barbecue Sauce",
                        Price = 7.29m
                 }
                    );
                context.SaveChanges();
            }
        }
    }
}
