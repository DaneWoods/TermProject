using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TermProject.Repositories;

namespace TermProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
             AppDbContext context = app.ApplicationServices
                .GetRequiredService<AppDbContext>();
            context.Database.Migrate();
            if (!context.Animals.Any())
            {
                context.Animals.AddRange(
                    new Animal { Class = "Mammal", Name = "Chimpanzee", Description = "Very human like", Diet = "Omnivore" },
                    new Animal { Class = "Bird", Name = "Blue Jay", Description = "Hop around", Diet = "Omnivore" },
                    new Animal { Class = "Fish", Name = "Gold Fish", Description = "Small household fish", Diet = "Omnivore" },
                    new Animal { Class = "Reptile", Name = "Bearded Dragon", Description = "Dessert Lizards", Diet = "Omnivore" },
                    new Animal { Class = "Amphibian", Name = "Toad", Description = "Very Chubby", Diet = "Omnivore" },
                    new Animal { Class = "Arthropod", Name = "Trapdoor spider", Description = "Very sneaky", Diet = "Carnivore" }
                );
                context.SaveChanges();
            }
        }
    }
}
