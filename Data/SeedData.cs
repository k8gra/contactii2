using Microsoft.EntityFrameworkCore;
using contactii2.Data;
using contactii2.Models;

namespace projetfinal.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Categorie.Any())
                {
                    return; //deja seeded
                }
                context.Categorie.AddRange(
                    new Categorie
                    {
                        CategorieName = "Famille"
                    },
                    new Categorie
                    {
                        CategorieName = "Amis"
                    },
                    new Categorie
                    {
                        CategorieName = "Travail"
                    },
                    new Categorie
                    {
                        CategorieName = "Autres"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
