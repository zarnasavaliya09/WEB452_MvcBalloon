using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBalloon.Data;
namespace MvcBalloon.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new MvcBalloonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBalloonContext>>()))
            {
                // Look for any movies.
                if (context.Balloon.Any())
                {
                    return;   // DB has been seeded
                }

                context.Balloon.AddRange(
                    new Balloon
                    {
                        Category = "Party Supplies",
                        Occassion = "Valentine",
                        Color = "Red",
                        Size = "Medium",
                        Shape = "Heart",
                        Price=   2.25M
                    },

                    new Balloon
                    {
                        Category = "Toy",
                        Occassion = "Birthday",
                        Color = "Pink",
                        Size = "Medium",
                        Shape = "Round",
                        Price = 5.25M
                    },

                    new Balloon
                    {
                        Category = "Party",
                        Occassion = "Baby Shower",
                        Color = "Blue",
                        Size = "Medium",
                        Shape = "Round",
                        Price = 1.25M
                    },

                    new Balloon
                    {
                        Category = "Party",
                        Occassion = "Wedding",
                        Color = "Silver",
                        Size = "Large",
                        Shape = "Heart",
                        Price = 3.25M
                    }
                );
                context.SaveChanges();
            }
        
        }
    }
}
